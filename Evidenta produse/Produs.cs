using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidenta_produse
{
    public class Produs
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public Pret Pret { get; set; }
        public uint Stoc { get; set; }
        public Producator Producator { get; set; }

        public delegate void PriceChangedEventHandler(object source, EventArgs args);
        public delegate void StocChangedEventHandler(object source, EventArgs args);

        public event PriceChangedEventHandler PriceChanged;
        public event StocChangedEventHandler StocChanged;

        protected virtual void OnPriceChanged()
        {
            if (PriceChanged != null)
                PriceChanged(this, EventArgs.Empty);
        }

        protected virtual void OnStocChanged()
        {
            if(StocChanged != null)
                StocChanged(this, EventArgs.Empty);
        }

    }


}
