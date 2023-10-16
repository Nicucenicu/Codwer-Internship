using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidenta_produse
{
    public class Client
    {
        private string[] Inbox { get; set; } = new string[10];
        public string Email { get; set; }
        public Moneda Moneda { get; set; }
        public List<Guid> ProduseFavorite { get; set; }

        public Client(string email, Moneda moneda, List<Guid> produseFavorite)
        {
            Email = email;
            Moneda = moneda;
            ProduseFavorite = produseFavorite;
        }

        public bool Notifica(string mesaj)
        {
            if (mesaj.Length > 60)
            {
                return false;
            }

            if (Inbox.Length >= 10)
            {
                throw new OutOfMemoryException("Inbox-ul este plin și nu mai poate primi mesaje noi.");
            }

            Inbox = Inbox.Append(mesaj).ToArray();
            return true;
        }

        public void OnPriceChanged(object source, EventArgs args) 
        {

        }
    }
}
