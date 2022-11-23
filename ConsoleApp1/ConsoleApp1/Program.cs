using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        // --- Functions --- //
        
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        // --- End of Functions --- //

        static void Main(string[] args)
        {
            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);
        }
    }
}