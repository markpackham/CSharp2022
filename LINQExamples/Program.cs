namespace LINQExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ reminds me a lot of SQL

            string[] dogs = { "rover", "lassie", "k9", "scooby doo", "old yeller", "snoopy", "rin tin tin" };

            // find dogs that have spaces in their name
            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach (var dog in dogSpaces)
            {
                Console.WriteLine(dog);
            }
        }
    }
}