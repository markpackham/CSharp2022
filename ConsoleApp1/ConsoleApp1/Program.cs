using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        // --- Functions --- //
        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }

        // --- End of Functions --- //

        static void Main(string[] args)
        {
            SayHello();
        }
    }
}