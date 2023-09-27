using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics.Animale
{
    public class Omnivor : Animal
    {
        public Omnivor(string nume, decimal greutate, Dimensiune dimensiune, decimal viteza) : base(nume, greutate, dimensiune, viteza)
        {
            TipAnimal = "omnivor";
        }

        public override double Energie()
        {
            double coef=0;
            double energy=0;
            foreach(var food in Stomac)
            {
                if (food.tip == "animala")
                    coef = -0.5;
                else if (food.tip == "vegetala")
                    coef = 0.5;
             energy+=0.35 + coef*(double)Stomac.Average(x => x.greutate) + (double)Stomac.Sum(x => x.energie);
            }
            return energy;
        }
    }
}
