using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        // --- Functions --- //
        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} {1}", name, zipCode);
        }

        // --- End of Functions --- //

        static void Main(string[] args)
        {
            PrintInfo(zipCode:123,name:"Jimmy");
        }
    }
}