using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidenta_produse
{
    public class Reducere
    {
        public string Nume { get; set; }
        public DateTime? DataStart { get; set; }
        public DateTime? DataStop { get; set; }
        public Action<Produs> Aplica { get; set; }
    }
}
