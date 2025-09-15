using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huoltokirja
{
    public partial class AjoneuvoForm : Form
    {
        private Ajoneuvo ajoneuvo;
        private List<Ajoneuvo> kaikkiAjoneuvot;

        public AjoneuvoForm(Ajoneuvo valittuAjoneuvo, List<Ajoneuvo> ajoneuvot)
        {
            InitializeComponent();
            ajoneuvo = valittuAjoneuvo;
            kaikkiAjoneuvot = ajoneuvot;

            NaytaTiedot();
            AlustaToimenpiteet();
        }

        private void NaytaTiedot()
        {
            lblOtsikko.Text = $"{ajoneuvo.Nimi} ({ajoneuvo.Id})";

            dgvMerkinnat.DataSource = null;
            dgvMerkinnat.DataSource = ajoneuvo.Merkinnät;
        }

        private void AlustaToimenpiteet()
        {
            cmbToimenpide.Items.AddRange(new string[] {
                "Öljynvaihto", "Öljyn lisäys", "Tankkaus", "Rasvaus",
                "Renkaiden vaihto", "Muu huolto", "Vikailmoitus"
            });
            cmbToimenpide.SelectedIndex = 0;
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUusiMittari.Text, out int uusiMittari))
            {
                MessageBox.Show("Syötä kelvollinen mittarilukema!");
                return;
            }

            if (uusiMittari < ajoneuvo.ViimeisinMittarilukema)
            {
                MessageBox.Show("Mittarilukema ei voi olla pienempi kuin edellinen!");
                return;
            }

            var uusiMerkinta = new HuoltoMerkinta
            {
                Pvm = DateTime.Now,
                Käyttäjä = Environment.UserName,
                Mittarilukema = uusiMittari,
                Toimenpide = cmbToimenpide.SelectedItem?.ToString(),
                Kuvaus = txtKuvaus.Text,
                OnkoVikailmoitus = chkVikailmoitus.Checked
            };

            ajoneuvo.Merkinnät.Add(uusiMerkinta);
            ajoneuvo.ViimeisinMittarilukema = uusiMittari;

            MessageBox.Show("Merkintä tallennettu onnistuneesti!");
            DialogResult = DialogResult.OK;
        }

    }
}