using Evidenta_produse;
using System;
using System.Collections.Generic;

namespace Evidenta_produse
{
    public class Pret
    {
        static Dictionary<Moneda, decimal> Curs = new Dictionary<Moneda, decimal>
        {      
            { Moneda.LEU, 1.0m },
            { Moneda.EUR, 19.4m },
            { Moneda.USD, 18.1m }
        };
        public decimal Valoare { get; set; }
        public Moneda Moneda { get; set; } = new Moneda();
        public decimal ValoareCurs(Moneda moneda)
        {
            if (Curs.ContainsKey(moneda))
            {
                return Valoare / Curs[moneda];
            }
            else
            {
                throw new ArgumentException("Moneda nu este suportată.");
            }
        }

    }

}
