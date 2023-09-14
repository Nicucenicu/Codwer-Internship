int x;
do
{
    Console.WriteLine("Introdu numar > 100");
    if (int.TryParse(Console.ReadLine(), out x))
    {
    }
    else
    {
        Console.WriteLine("Introdu un numar valid");
    }
}
while (x < 100);

int result = 0;
while (x > 0)
{
    result = result * 10 + x % 10;
    x /= 10;
}
Console.WriteLine(result);

if (Math.Sqrt(result) % 1 == 0)
    Console.WriteLine("Numarul este patrat perfect");
else Console.WriteLine("Numarul nu este patrat perfect");