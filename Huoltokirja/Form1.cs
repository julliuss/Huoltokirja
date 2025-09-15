using System.Text.Json;

namespace Huoltokirja
{
    public partial class Form1 : Form
    {
        private List<Ajoneuvo> ajoneuvot;
        public Form1()
        {
            InitializeComponent();
            LataaData();
        }
        private void LataaData()
        {
            ajoneuvot = TiedostonHallinta.LataaAjoneuvot();

            if (ajoneuvot.Count == 0)
            {
                ajoneuvot = TiedostonHallinta.LuoTestiAjoneuvot();
                TiedostonHallinta.TallennaAjoneuvot(ajoneuvot);
            }

            PaivitaOpiskelijaNakyma();
            PaivitaOpettajaNakyma();
        }

        private void PaivitaOpiskelijaNakyma()
        {
            cmbAjoneuvot.DataSource = null;
            cmbAjoneuvot.DataSource = ajoneuvot;
            cmbAjoneuvot.DisplayMember = "Nimi";
            cmbAjoneuvot.ValueMember = "Id";

            var naytettavatTiedot = new List<object>();

            foreach (var ajoneuvo in ajoneuvot)
            {
                string viimeisinToimenpide = "Ei merkint�j�";

                if (ajoneuvo.Merkinn�t.Count > 0)
                {
                    viimeisinToimenpide = ajoneuvo.Merkinn�t.Last().Toimenpide;
                }

                naytettavatTiedot.Add(new
                {
                    ID = ajoneuvo.Id,
                    Nimi = ajoneuvo.Nimi,
                    Mittari = $"{ajoneuvo.ViimeisinMittarilukema} t",
                    Huoltov�li = $"{ajoneuvo.Huoltov�liTunnit} t",
                    Viimeisin = viimeisinToimenpide
                });
            }

            dgvOpiskelija.DataSource = null;
            dgvOpiskelija.DataSource = naytettavatTiedot;
        }

        private void PaivitaOpettajaNakyma()
        {
            var naytettavatTiedot = new List<object>();

            foreach (var ajoneuvo in ajoneuvot)
            {
                string viimeisinToimenpide = "Ei merkint�j�";
                int merkintoja = ajoneuvo.Merkinn�t.Count;
                bool onkoVikaa = ajoneuvo.Merkinn�t.Any(m => m.OnkoVikailmoitus);

                if (merkintoja > 0)
                {
                    viimeisinToimenpide = ajoneuvo.Merkinn�t.Last().Toimenpide;
                }

                naytettavatTiedot.Add(new
                {
                    Tunnus = ajoneuvo.Id,
                    Nimi = ajoneuvo.Nimi,
                    Mittari = $"{ajoneuvo.ViimeisinMittarilukema} t",
                    Huoltov�li = $"{ajoneuvo.Huoltov�liTunnit} t",
                    Merkint�j� = $"{merkintoja} kpl",
                    Viimeisin = viimeisinToimenpide,
                    Vika = onkoVikaa ? "Ei ole" : "On"
                });
            }

            dgvOpettaja.DataSource = null;
            dgvOpettaja.DataSource = naytettavatTiedot;
        }

        private void btnValitse_Click(object sender, EventArgs e)
        {
            if (cmbAjoneuvot.SelectedItem is Ajoneuvo valittuajoneuvo)
            {
                try
                {
                    var asetukset = new JsonSerializerOptions { WriteIndented = true };
                    string json = JsonSerializer.Serialize(valittuajoneuvo, asetukset);
                    var ajoneuvoKopio = JsonSerializer.Deserialize<Ajoneuvo>(json, asetukset);

                    using (var ajoneuvoForm = new AjoneuvoForm(ajoneuvoKopio, ajoneuvot))
                    {
                        if (ajoneuvoForm.ShowDialog() == DialogResult.OK)
                        {
                            var paivitettava = ajoneuvot.FirstOrDefault(a => a.Id == ajoneuvoKopio.Id);
                            if (paivitettava != null)
                            {
                                paivitettava.Merkinn�t = ajoneuvoKopio.Merkinn�t;
                                paivitettava.ViimeisinMittarilukema = ajoneuvoKopio.ViimeisinMittarilukema;
                            }

                            TiedostonHallinta.TallennaAjoneuvot(ajoneuvot);

                            PaivitaOpiskelijaNakyma();
                            PaivitaOpettajaNakyma();

                            MessageBox.Show("Merkint� tallennettu onnistuneesti!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Virhe: {ex.Message}");
                }
            }
        }

        private void btnVieCSV_Click(object sender, EventArgs e)
        {
            if (dgvOpettaja.CurrentRow == null) return;

            var valittu = dgvOpettaja.CurrentRow.DataBoundItem as dynamic;
            string ajoneuvoId = valittu.Tunnus;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV-tiedosto|*.csv";
            saveFileDialog.Title = "Vie ajoneuvon tiedot CSV-tiedostoon";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TiedostonHallinta.VieAjoneuvonCSV(ajoneuvot, ajoneuvoId, saveFileDialog.FileName);
                MessageBox.Show("CSV-tiedosto luotu!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dvgOpiskelija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbAjoneuvot_SelectionChanged(object sender, EventArgs e)
        {
            if (cmbAjoneuvot.SelectedItem is Ajoneuvo valittuAjoneuvo)
            {
                var ajoneuvoForm = new AjoneuvoForm(valittuAjoneuvo, ajoneuvot);
                ajoneuvoForm.ShowDialog();
                ajoneuvot = TiedostonHallinta.LataaAjoneuvot();
                PaivitaOpiskelijaNakyma();
                PaivitaOpettajaNakyma();
            }
        }
    }
}
