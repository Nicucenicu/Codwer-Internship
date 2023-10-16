using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Evidenta_produse
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<Producator> producatori = new List<Producator>();

            var producatori = new List<Producator>
        {
            new Producator
            {
                Nume = "Samsung",
                Reduceri = new List<Reducere>
                {
                    new Reducere { Nume = "Reducere 1", DataStart = DateTime.Now, DataStop = DateTime.Now.AddDays(7) },
                    new Reducere { Nume = "Reducere 2", DataStart = null, DataStop = DateTime.Now.AddMonths(1) }
                }
            },
            new Producator
            {
                Nume = "Xiaomi",
                Reduceri = new List<Reducere>
                {
                    new Reducere { Nume = "Reducere 3", DataStart = DateTime.Now, DataStop = null },
                    new Reducere { Nume = "Reducere 4", DataStart = DateTime.Now.AddDays(10), DataStop = DateTime.Now.AddMonths(2) }
                }
            },
            new Producator
            {
                Nume = "Apple",
                Reduceri = new List<Reducere>
                {
                    new Reducere { Nume = "Reducere 3", DataStart = DateTime.Now, DataStop = DateTime.Now.AddDays(15) },
                    new Reducere { Nume = "Reducere 4", DataStart = null, DataStop = DateTime.Now.AddMonths(2) }
                }
            }
        };

            var catalog = new Catalog
            {
                ListaProduse = new List<Produs>
            {
                new Produs
                {
                    Id = Guid.NewGuid(),
                    Nume = "S 23 plus",
                    Pret = new Pret { Valoare = 20000, Moneda = Moneda.LEU },
                    Stoc = 50,
                    Producator = producatori[0]
                },
                new Produs
                {
                    Id = Guid.NewGuid(),
                    Nume = "caca T12",
                    Pret = new Pret { Valoare = 200, Moneda = Moneda.EUR },
                    Stoc = 30,
                    Producator = producatori[1]
                },
                new Produs
                {
                    Id = Guid.NewGuid(),
                    Nume = "Iphone 15",
                    Pret = new Pret { Valoare = 1000, Moneda = Moneda.EUR },
                    Stoc = 150,
                    Producator = producatori[2]
                },
                new Produs
                {
                    Id = Guid.NewGuid(),
                    Nume = "Iphone 15 pro",
                    Pret = new Pret { Valoare = 1500, Moneda = Moneda.USD },
                    Stoc = 100,
                    Producator = producatori[2]
                }
            },
                ListaReduceri = new List<Reducere>
            {
                new Reducere { Nume = "Reducere Catalog 1", DataStart = DateTime.Now, DataStop = null },
                new Reducere { Nume = "Reducere Catalog 2", DataStart = DateTime.Now.AddDays(5), DataStop = DateTime.Now.AddMonths(2) }
            }
            };

           
            var clienti = new List<Client>
        {
            new Client("client1@example.com", Moneda.LEU, new List<Guid> { catalog.ListaProduse[0].Id, Guid.NewGuid() }),
            new Client("client2@example.com", Moneda.EUR, new List<Guid> {catalog.ListaProduse[2].Id,catalog.ListaProduse[3].Id}),
            new Client("client3@example.com", Moneda.USD, new List<Guid> { catalog.ListaProduse[1].Id, Guid.NewGuid(), catalog.ListaProduse[2].Id}),
        };

            var r = new Reducere
            {
                Aplica = (p) => { p.Pret.Valoare *= 0.8m; }
            };

            r.Aplica(catalog.ListaProduse.First());
        }
    }
}
