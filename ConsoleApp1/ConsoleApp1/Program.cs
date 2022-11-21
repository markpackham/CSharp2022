using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");

            string strVal = dblFromStr.ToString();
            Console.WriteLine($"Data type: {strVal.GetType()}");
            double dblNum = 12.345;
            Console.WriteLine($"Int: {(int)dblNum}");
            int intNum = 10;
            long longNum = intNum;
        }
    }
}