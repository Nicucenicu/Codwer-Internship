using System;

namespace Espressor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Espressor espressor = new Espressor();

            while (true)
            {
                Console.WriteLine("Ce doriti să faceti?");
                Console.WriteLine("1. Adaugati apa");
                Console.WriteLine("2. Adaugati boabe de cafea");
                Console.WriteLine("3. Adaugati zahar in rezervor");
                Console.WriteLine("4. Puneti cana");
                Console.WriteLine("5. Preparati cafea");
                Console.WriteLine("6. Scoateti cana");
                Console.WriteLine("0. Iesire");

                string alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        Console.WriteLine("Cata apa?");
                        int apa = int.Parse(Console.ReadLine());
                        espressor.AdaugaApa(apa);
                        break;
                    case "2":
                        Console.WriteLine("Cate boabe de cafea?");
                        int boabe = int.Parse(Console.ReadLine());
                        espressor.AdaugaBoabe(boabe);
                        break;
                    case "3":
                        Console.WriteLine("Cat zahar?");
                        int zahar = int.Parse(Console.ReadLine());
                        espressor.AdaugaZahar(zahar);
                        break;
                    case "4":
                        espressor.PuneCana();
                        break;
                    case "5":
                        if (!espressor.Detecteaza()) break;
                        Console.WriteLine("Cat zahar doriti în cafea?");
                        int cantitateZahar = int.Parse(Console.ReadLine());
                        espressor.PreparaCafea(cantitateZahar);
                        break;
                    case "6":
                        espressor.ScoateCana();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Alegere invalida, incercati din nou.");
                        break;
                }
            }
        }
    }
}

