using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        // --- Functions --- //
        static double GetSum2(double x = 1, double y =1)
        {
            return x + y;
        }

        static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }

        // --- End of Functions --- //

        static void Main(string[] args)
        {
            Console.WriteLine("{0}",GetSum2(1,2));
            Console.WriteLine("{0}",GetSum2("1","2"));
        }
    }
}