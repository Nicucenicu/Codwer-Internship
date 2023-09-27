using OOP_Basics.Hrana;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics.Animale
{
    public class Erbivor : Animal
    {
        public Erbivor(string nume, decimal greutate, Dimensiune dimensiune, decimal viteza) : base(nume, greutate, dimensiune, viteza)
        {
            TipAnimal = "erbivor";
        }
        public override void Mananca(Mancare m)
        {
            if (m.tip == "vegetala")
                base.Mananca(m);
        }
        public override double Energie()
        {
            return 0.5 + 1 / 3 * (double)Stomac.Average(x => x.greutate) + (double)Stomac.Sum(x => x.energie);
        }
    }
}
