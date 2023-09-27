using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics.Hrana
{
    public abstract class Mancare
    {
        public decimal greutate;
        [Range(0, 0.05)]
        public decimal energie;
        public string tip { get; set; }
        public Mancare(decimal greutate, decimal energie)
        {
            this.greutate = greutate;
            this.energie = energie;
        }

    }
}
