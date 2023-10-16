using System;

namespace Espressor
{
    public class Espressor
    {
        RezervorApa rezervorApa = new RezervorApa();
        RezervorBoabe rezervorBoabe = new RezervorBoabe();
        SuportCana suportCana = new SuportCana();
        UnitatePreparare unitatePreparare = new UnitatePreparare();
        RezervorZahar rezervorZahar = new RezervorZahar();

        public bool Detecteaza()
        {
            rezervorApa.Detecteaza();
            rezervorBoabe.Detecteaza();
            rezervorZahar.Detecteaza();

            var i = 0;
            if (!rezervorApa.SenzorApa)
            {
                Console.WriteLine("Adauga apa");
                i++;
            }
            if (!rezervorBoabe.SenzorBoabe)
            {
                Console.WriteLine("Adauga boabe");
                i++;
            }
            if (!rezervorZahar.SenzorZahar)
            {
                Console.WriteLine("Adauga zahar");
                i++;
            }
            if (!suportCana.EsteCana)
            {
                Console.WriteLine("Introdu cana");
                i++;
            }
            return i == 0;
        }

        public void AdaugaApa(int cantitate)
        {
            rezervorApa.AdaugaApa(cantitate);
        }

        public void AdaugaBoabe(int cantitate)
        {
            rezervorBoabe.AdaugaBoabe(cantitate);
        }

        public void PuneCana()
        {
            suportCana.PuneCana();
        }

        public void ScoateCana()
        {
            suportCana.ScoateCana();
        }

        public void AdaugaZahar(int cantitate)
        {
            rezervorZahar.AdaugaZahar(cantitate);
        }

        public void PreparaCafea(int cantitateZahar)
        {
            unitatePreparare.Prepara(rezervorApa, rezervorBoabe, rezervorZahar, cantitateZahar);
        }
    }

    class RezervorApa
    {
        public bool SenzorApa { get; private set; }
        public int CantitateApa { get; set; }

        public void Detecteaza()
        {
            SenzorApa = CantitateApa > 100;
        }

        public void AdaugaApa(int cantitate)
        {
            CantitateApa += cantitate;
        }
    }

    class RezervorBoabe
    {
        public bool SenzorBoabe { get; private set; }
        public int CantitateBoabe { get; set; }

        public void Detecteaza()
        {
            SenzorBoabe = CantitateBoabe > 30;
        }

        public void AdaugaBoabe(int cantitate)
        {
            CantitateBoabe += cantitate;
        }
    }

    class SuportCana
    {
        public bool EsteCana { get; private set; }

        public void PuneCana()
        {
            EsteCana = true;
        }

        public void ScoateCana()
        {
            EsteCana = false;
        }
    }

    class RezervorZahar
    {
        public bool SenzorZahar { get; private set; }
        public int CantitateZahar { get; set; }

        public void Detecteaza()
        {
            SenzorZahar = CantitateZahar > 30;
        }

        public void AdaugaZahar(int cantitate)
        {
            CantitateZahar += cantitate;
        }
    }

    class UnitatePreparare
    {
        public void Prepara(RezervorApa rezervorApa, RezervorBoabe rezervorBoabe, RezervorZahar rezervorZahar, int cantitateZahar)
        {
            rezervorApa.CantitateApa -= 60;
            rezervorBoabe.CantitateBoabe -= 5;
            rezervorZahar.CantitateZahar -= cantitateZahar;
            Console.WriteLine("Se prepara cafea.");
        }
    }

}
