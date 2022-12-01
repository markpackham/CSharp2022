// maintain old style main Program style
// https://learn.microsoft.com/en-gb/dotnet/core/tutorials/top-level-templates#use-the-old-program-style

namespace SelectZipListFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ---------- SELECT ----------
            // Select allows us to execute a function 
            // on each item in a list
            Console.WriteLine("-------------");
            Console.WriteLine("SELECT");
            var oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));
            var squares = oneTo10.Select(x => x * x);
            foreach(var square in squares)
            {
                Console.WriteLine(square);
            }

            // ---------- ZIP ----------
            // Zip applies a function to two lists (nothing to do with zip files or zip codes)
            // Add values in 2 lists together
            // so {1,3,4} + {4,6,8} = {5,9,12}
            Console.WriteLine("-------------");
            Console.WriteLine("ZIP");
            var listOne = new List<int>(new int[] {1,3,4});
            var listTwo = new List<int>(new int[] {4,6,8});
            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();
            foreach(var item in sumList)
            {
                Console.WriteLine(item);
            }

        }
    }
}