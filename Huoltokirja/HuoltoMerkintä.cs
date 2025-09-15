using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huoltokirja
{
    public class HuoltoMerkinta
    {
        public DateTime Pvm { get; set; }
        public string Käyttäjä { get; set; }
        public int Mittarilukema { get; set; }
        public string Toimenpide { get; set; }
        public string Kuvaus { get; set; }
        public bool OnkoVikailmoitus { get; set; }
    }
}
