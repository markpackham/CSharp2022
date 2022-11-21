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
            for(int j = 0; j < randomArray.Length; j++)
            {
                Console.WriteLine("Index:{0} - {1}", j, randomArray[j]);
            }

            Console.WriteLine("--------------");
            string[,] customerNames = new string[2, 2] { { "Bob","Smith"},{ "Sally","Jones"} };
            Console.WriteLine(customerNames[0,0]);
            for (int j = 0; j < customerNames.GetLength(0); j++)
            {
                for (int k = 0; k < customerNames.GetLength(0); k++)
                {
                    Console.WriteLine("Index:{0}", customerNames[j,k]);
                }
                Console.WriteLine();
            }
        }
    }
}