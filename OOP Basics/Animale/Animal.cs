using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Basics.Hrana;

namespace OOP_Basics.Animale
{
    public abstract class Animal
    {
        public string Nume { get; set; }
        public decimal Greutate { get; }
        public Dimensiune Dimensiune { get; }
        public decimal Viteza { get; }
        protected List<Mancare> Stomac = new List<Mancare>();
        public static int ContorAnimale { get; set; }
        public string TipAnimal { get; set; }

        public enum TipdeAnimale
        {
            Lup,
            Urs,
            Oaie,
            Veverita,
            Pisica,
            Vaca
        }
        public Animal(string nume, decimal greutate, Dimensiune dimensiune, decimal viteza)
        {
            Nume = nume;
            Greutate = greutate;
            Dimensiune = dimensiune;
            Viteza = viteza;
            ContorAnimale++;
            TipAnimal = string.Empty;
        }
        public virtual void Mananca(Mancare m)
        {
            if (m.greutate < Greutate / 8)
            {
                Stomac.Add(m);
                Console.WriteLine(Nume + " mananca ");
            }
        }
        public abstract double Energie();
        public virtual void Alearga(decimal distanta)
        {
            Console.WriteLine(Nume + " parcurge in " + (distanta / (Viteza / Stomac.Sum(x => x.energie))).ToString("0.00") + " secunde");
        }
        public override string ToString()
        {
            return "Animal: " + TipAnimal +
                "\nNume: " + Nume +
                "\nGreutate: " + Greutate +
                " kg\nDimensiuni: " + Dimensiune.Lungime + " x " + Dimensiune.Latime + " x " + Dimensiune.Inaltime +
                "\nViteza: " + Viteza + " m/s\n";
        }
    }
}
