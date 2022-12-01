namespace LINQExamples
{
    internal class Program
    {

        static int[] QueryIntArray()
        {
            int[] nums = {5,10,15,20,25,35};

            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;

            foreach(int num in gt20)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine($"Get Type: {gt20.GetType()}");

            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            nums[0] = 40;
            foreach (int num in gt20)
            {
                Console.WriteLine(num);
            }

            return arrayGT20;
        }


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

            Console.WriteLine("---------");
            Console.WriteLine("QueryIntArray");
            Console.WriteLine("---------");

            int[] intArray = QueryIntArray();
            foreach (int num in intArray)
            {
                Console.WriteLine(num);
            }

        }
    }
}