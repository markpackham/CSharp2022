using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        // --- Functions --- //
        static double GetSomeMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }
        

        // --- End of Functions --- //

        static void Main(string[] args)
        {
            Console.WriteLine("{0}", GetSomeMore(1, 2, 3, 4, 5));
        }
    }
}