// maintain old style main Program style
// https://learn.microsoft.com/en-gb/dotnet/core/tutorials/top-level-templates#use-the-old-program-style

namespace SelectZipListFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));
            var squares = oneTo10.Select(x => x * x);
            foreach(var square in squares)
            {
                Console.WriteLine(square);
            }
        }
    }
}