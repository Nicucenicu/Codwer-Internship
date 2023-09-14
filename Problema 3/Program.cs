using System;
namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu nume");
            string numeStr = Console.ReadLine();
            numeStr = numeStr.ToLower();
            while (numeStr.Length > 0)
            {
                Console.Write(numeStr[0] + "= ");
                int count = 0;
                for (int i = 0; i < numeStr.Length; i++)
                {
                    if (numeStr[0] == numeStr[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                numeStr = numeStr.Replace(numeStr[0].ToString(), string.Empty);
            }
        }
    }
}
