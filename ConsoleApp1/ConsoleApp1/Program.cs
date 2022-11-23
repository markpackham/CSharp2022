using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        // --- Functions --- //


        // --- End of Functions --- //

        static void Main(string[] args)
        {
            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of the Week: {0}", awesomeDate.DayOfWeek);
        }
    }
}