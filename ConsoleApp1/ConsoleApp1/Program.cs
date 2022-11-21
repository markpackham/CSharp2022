using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] favNums = new int[3];
            favNums[0] = 42;
            Console.WriteLine(favNums[0]);
            string[] customers = { "Bob","Alice","Sue" };
            var employees = new[] { "Mike", "Bill", "John" };
            object[] randomArray = { "Paul", 45, 1.234};
            Console.WriteLine(randomArray[2].GetType());
            Console.WriteLine(randomArray.Length);
        }
    }
}