using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics.Animale
{
    public struct Dimensiune
    {
        public decimal Lungime { get; set; }
        public decimal Latime { get; set; }
        public decimal Inaltime { get; set; }

        public Dimensiune(decimal lungime, decimal latime, decimal inaltime)
        {
            Lungime = lungime;
            Latime = latime;
            Inaltime = inaltime;
        }
    }
}
