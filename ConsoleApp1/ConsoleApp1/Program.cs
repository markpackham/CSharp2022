using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        // --- Functions --- //
        public static void NonRefSwap(int num3, int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }


        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }
        

        // --- End of Functions --- //

        static void Main(string[] args)
        {
            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before Swap num1: {0} num2: {1}",num3, num4);
            NonRefSwap(num3, num4);
            Console.WriteLine("NonRefSwap num1: {0} num2: {1}", num3, num4);
            Swap(ref num3, ref num4);
            Console.WriteLine("After Swap num1: {0} num2: {1}", num3, num4);
        }
    }
}