using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidenta_produse
{
    public class Producator
    {
        public string Nume { get; set; }
        public List<Reducere> Reduceri { get; set; }
        public Producator(string nume, List<Reducere> reduceri) 
        {
            Nume = nume;
            Reduceri = reduceri;
        }
        public Producator()
        {
            
        }
    }
}
