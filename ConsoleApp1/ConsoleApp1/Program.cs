using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        // --- Functions --- //

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} the code {1}", cc, (int)cc);
        }

        // --- End of Functions --- //

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow,
        }

        static void Main(string[] args)
        {
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);
        }
    }
}