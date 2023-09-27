using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics.Hrana
{
    public class Planta : Mancare
    {
        public Planta(decimal greutate, decimal energie) : base(greutate, energie)
        {
            tip = "vegetala";
        }
    }
}
