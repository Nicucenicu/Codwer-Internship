Console.WriteLine("Introdu numere");
var input = Console.ReadLine();
string[] stringFormat = input.Split(' ');
double[] array = new double[stringFormat.Length];
for (int i = 0; i < stringFormat.Length; i++)
    if (double.TryParse(stringFormat[i], out array[i]))
    {
        if (array[i] % 1 != 0) Console.Write(array[i] + " ");
    }
Console.WriteLine();
double minim = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minim)
        minim = array[i];
}
Console.WriteLine("Cel mai mic numar este: " + minim);
