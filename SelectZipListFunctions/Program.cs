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

            // ---------- Aggregate/Sum ----------
            Console.WriteLine("-------------");
            Console.WriteLine("Aggregate/Sum");
            var numList2 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum {0}", numList2.Aggregate((a,b)=>a + b));


            // ---------- Average ----------
            Console.WriteLine("-------------");
            Console.WriteLine("Average");
            var numList3 = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("AVG : {0}",
                numList3.AsQueryable().Average());

            // ---------- All meeting condition ----------
            Console.WriteLine("-------------");
            Console.WriteLine("All meeting a condition (eg > or <)");

            var numList4 = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("All > 3 : {0}",
                numList4.All(x => x > 3));

            // ---------- Any meeting conditon ----------
            Console.WriteLine("-------------");
            Console.WriteLine("Any meeting conditon");

            var numList5 = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("Any > 3 : {0}",
                numList5.Any(x => x > 3));

            // ---------- Distinct ----------
            Console.WriteLine("-------------");
            Console.WriteLine("Distinct - purge duplicates");

            var numList6 = new List<int>() { 1, 2, 3, 2, 3 };

            Console.WriteLine("Distinct : {0}",
                string.Join(", ", numList6.Distinct()));

            // ---------- Except ----------
            Console.WriteLine("-------------");
            Console.WriteLine("Except - return all values except exceptions");

            var numList7 = new List<int>() { 1, 2, 3, 2, 3 };
            var numList8 = new List<int>() { 3 };

            Console.WriteLine("Except : {0}",
                string.Join(", ", numList7.Except(numList8)));

            // ---------- Intersect ----------
            // Receives 2 lists and returns values that both lists have
            Console.WriteLine("-------------");
            Console.WriteLine("Intersect - opposite of Except");
            var numList9 = new List<int>() { 1, 2, 3, 2, 3 };
            var numList10 = new List<int>() { 2, 3 };

            Console.WriteLine("Intersect : {0}",
                string.Join(", ", numList9.Intersect(numList10)));

        }
    }
}