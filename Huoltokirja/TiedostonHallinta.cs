using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Huoltokirja
{
    public static class TiedostonHallinta
    {
        private static string tiedostopolku = Path.Combine(Environment.CurrentDirectory, "data", "ajoneuvot.json");

        public static List<Ajoneuvo> LataaAjoneuvot()
        {
            try
            {
                if (!File.Exists(tiedostopolku))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(tiedostopolku));
                    return new List<Ajoneuvo>();
                }

                string json = File.ReadAllText(tiedostopolku);
                var ajoneuvot = JsonSerializer.Deserialize<List<Ajoneuvo>>(json);

                if (ajoneuvot != null)
                {
                    foreach (var ajoneuvo in ajoneuvot)
                    {
                        if (ajoneuvo.Merkinnät == null)
                        {
                            ajoneuvo.Merkinnät = new List<HuoltoMerkinta>();
                        }
                        else
                        {
                            ajoneuvo.Merkinnät = new List<HuoltoMerkinta>(ajoneuvo.Merkinnät);
                        }
                    }
                }

                return ajoneuvot ?? new List<Ajoneuvo>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe datan lataamisessa: {ex.Message}");
                return new List<Ajoneuvo>();
            }
        }

        public static void TallennaAjoneuvot(List<Ajoneuvo> ajoneuvot)
        {
            try
            {
                string kansio = Path.GetDirectoryName(tiedostopolku);
                if (!Directory.Exists(kansio))
                {
                    Directory.CreateDirectory(kansio);
                }

                var asetukset = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };

                string json = JsonSerializer.Serialize(ajoneuvot, asetukset);
                File.WriteAllText(tiedostopolku, json, Encoding.UTF8);

                Console.WriteLine("Data tallennettu onnistuneesti!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tallennusvirhe: {ex.Message}");
                Console.WriteLine($"Tallennusvirhe: {ex.ToString()}");
            }
        }

        public static void VieAjoneuvonCSV(List<Ajoneuvo> ajoneuvot, string ajoneuvoId, string polku)
        {
            try
            {
                var ajoneuvo = ajoneuvot.FirstOrDefault(a => a.Id == ajoneuvoId);
                if (ajoneuvo == null) return;

                using (StreamWriter sw = new StreamWriter(polku, false, Encoding.UTF8))
                {
                    sw.WriteLine($"Ajoneuvo;{ajoneuvo.Nimi};({ajoneuvo.Id})");
                    sw.WriteLine($"Viimeisin mittarilukema;{ajoneuvo.ViimeisinMittarilukema}t");
                    sw.WriteLine($"Huoltoväli;{ajoneuvo.HuoltoväliTunnit}t");
                    sw.WriteLine();
                    sw.WriteLine("Pvm;Mittarilukema;Toimenpide;Kuvaus;Vikailmoitus;Käyttäjä");

                    foreach (var merkinta in ajoneuvo.Merkinnät.OrderByDescending(m => m.Pvm))
                    {
                        sw.WriteLine($"{merkinta.Pvm:d};{merkinta.Mittarilukema};{merkinta.Toimenpide};{merkinta.Kuvaus};{merkinta.OnkoVikailmoitus};{merkinta.Käyttäjä}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CSV-viennissä virhe: {ex.Message}");
            }
        }

        public static List<Ajoneuvo> LuoTestiAjoneuvot()
        {
            return new List<Ajoneuvo>
    {
        new Ajoneuvo
        {
            Id = "KON-001",
            Nimi = "Kaivuri",
            HuoltoväliTunnit = 300,
            ViimeisinMittarilukema = 6050,
            Merkinnät = new List<HuoltoMerkinta> 
            {
                new HuoltoMerkinta
                {
                    Pvm = DateTime.Now.AddDays(-4),
                    Käyttäjä = "Opiskelija 1",
                    Mittarilukema = 6050,
                    Toimenpide = "Öljyn lisäys",
                    Kuvaus = "Lisätty 2 litraa"
                }
            }
        },
        new Ajoneuvo
        {
            Id = "KON-002",
            Nimi = "Auto",
            HuoltoväliTunnit = 100,
            ViimeisinMittarilukema = 120,
            Merkinnät = new List<HuoltoMerkinta> 
            {
                new HuoltoMerkinta
                {
                    Pvm = DateTime.Now.AddDays(-2),
                    Käyttäjä = "Opiskelija 2",
                    Mittarilukema = 120,
                    Toimenpide = "Tankkaus",
                    Kuvaus = "Täytetty tankki"
                }
            }
        },
        new Ajoneuvo
        {
            Id = "KON-003",
            Nimi = "Traktori",
            HuoltoväliTunnit = 200,
            ViimeisinMittarilukema = 2500,
            Merkinnät = new List<HuoltoMerkinta>()
        }
    };
        }
    }
}
