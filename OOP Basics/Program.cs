using OOP_Basics.Animale;
using OOP_Basics.Hrana;

public class Program
{
    static void Main(string[] args)
    {
        Animal lup = new Carnivor("Luup", 30, new Dimensiune(3, 2, 1), 20);
        Erbivor oaie = new Erbivor("Mioara", 35, new Dimensiune(2, 1, 1), 10);
        Omnivor urs = new Omnivor("Misa", 150, new Dimensiune(4, 3, 2), 18);
        Planta salata = new Planta(1, 0.02m);
        Carne sunca = new Carne(0.55m, 0.05m);
        lup.Mananca(sunca);
        lup.Mananca(sunca);
        oaie.Mananca(salata);
        oaie.Mananca(salata);
        oaie.Mananca(salata);
        urs.Mananca(sunca);
        urs.Mananca(salata);
        urs.Mananca(salata);
        urs.Mananca(salata);
        lup.Mananca(salata);

        lup.Alearga(200);
        oaie.Alearga(200);
        urs.Alearga(200);
        Console.WriteLine("s-au creat " + Animal.ContorAnimale + " animale\n");
        Console.WriteLine(lup);


        List<Animal> list = new List<Animal>(10);
        for (int i = 0; i < 10; i++)
        {

            var valori = Enum.GetValues(typeof(Animal.TipdeAnimale));
            Random random = new Random();
            Animal.TipdeAnimale tipdeAnimal = (Animal.TipdeAnimale)valori.GetValue(random.Next(valori.Length));
            var newAnimal = CreazaAnimal(tipdeAnimal, "Animal", random.Next(1, 300), new Dimensiune(random.Next(1, 5), random.Next(1, 5), random.Next(1, 5)), random.Next(1, 50));
            list.Add(newAnimal);
            foreach (var animala in list)
            {
                if (animala.TipAnimal == "carnivor")
                    animala.Mananca(sunca);
                else if (animala.TipAnimal == "erbivor")
                    animala.Mananca(salata);
                else
                {
                    animala.Mananca(sunca);
                }
            }
        }
        Console.WriteLine(list.Count + " animale mananca mancare.");
        Console.WriteLine(list.Where(x => x.TipAnimal == "carnivor").Count() + " animale mananca carne.");
        Console.WriteLine(list.Where(x => x.TipAnimal == "erbivor").Count() + " animale mananca plante.");

    }
    static Animal CreazaAnimal(Animal.TipdeAnimale tipAnimal, string nume, decimal greutate, Dimensiune dimensiune, decimal viteza)
    {
        switch (tipAnimal)
        {
            case Animal.TipdeAnimale.Pisica:
            case Animal.TipdeAnimale.Urs:
                return new Omnivor(nume, greutate, dimensiune, viteza);

            case Animal.TipdeAnimale.Vaca:
            case Animal.TipdeAnimale.Veverita:
            case Animal.TipdeAnimale.Oaie:
                return new Erbivor(nume, greutate, dimensiune, viteza);

            case Animal.TipdeAnimale.Lup:
                return new Carnivor(nume, greutate, dimensiune, viteza);
            default: throw new ArgumentException("tipul de animal nu este recunoscut.");
        }
    }
}

