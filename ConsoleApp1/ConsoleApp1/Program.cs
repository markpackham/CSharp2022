using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency (default UK £) : {0:c}", 23.455);
            Console.WriteLine("Padd with 0s : {0:d4}", 23);
            Console.WriteLine("3 Decimal Places : {0:f3}", 23.4559999999);
            Console.WriteLine("Commas : {0:n4}", 23000);

        }
    }
}