using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huoltokirja
{
    public class Ajoneuvo
    {
        public string Id { get; set; }
        public string Nimi { get; set; }
        public int HuoltoväliTunnit { get; set; }
        public int ViimeisinMittarilukema { get; set; }
        public List<HuoltoMerkinta> Merkinnät { get; set; } = new List<HuoltoMerkinta>();
    }
}
