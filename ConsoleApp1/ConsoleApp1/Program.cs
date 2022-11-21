using System;

namespace ConsoleApp1
{
    public class Program
    {

        // ---- Functions --- //

        static void PrintArray(int[] intArray, string mess)
        {
            foreach(int k in intArray)
            {
                Console.WriteLine("{0} : {1} ", mess, k);
            }
        }

        // ---- End of Functions //

        static void Main(string[] args)
        {
            int[] favNums = new int[3];
            favNums[0] = 42;
            Console.WriteLine(favNums[0]);
            string[] customers = { "Bob", "Alice", "Sue" };
            var employees = new[] { "Mike", "Bill", "John" };
            object[] randomArray = { "Paul", 45, 1.234 };
            Console.WriteLine(randomArray[2].GetType());
            Console.WriteLine(randomArray.Length);
            for (int j = 0; j < randomArray.Length; j++)
            {
                Console.WriteLine("Index:{0} - {1}", j, randomArray[j]);
            }

            Console.WriteLine("--------------");
            string[,] customerNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Jones" } };
            Console.WriteLine(customerNames[0, 0]);
            for (int j = 0; j < customerNames.GetLength(0); j++)
            {
                for (int k = 0; k < customerNames.GetLength(0); k++)
                {
                    Console.WriteLine("Index:{0}", customerNames[j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------");

            int[] randNums = { 1, 4, 9, 2 };

            PrintArray(randNums, "ForEach");
            Console.WriteLine("--------------");

            Array.Sort(randNums);
            Array.Reverse(randNums);
            Console.WriteLine("1 at index: {0}", Array.IndexOf(randNums, 1));
            randNums.SetValue(0, 1);
            int[] srcArray = { 1, 2, 3, };
            int[] dstArray = new int[2];
            int startInd = 0;
            int length = 2;
            Array.Copy(srcArray, startInd,dstArray, 0, length);
            PrintArray(dstArray, "Copy");
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            foreach(int m in anotherArray)
            {
                Console.WriteLine("Copy to : {0} ", m);
            }

            int[] numArray = { 1, 11, 22 };

        }
    }
}