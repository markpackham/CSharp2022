namespace IEnumeratorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalFarm myAnimals = new AnimalFarm();
            myAnimals[0] = new Animal("Napoleon");
            myAnimals[1] = new Animal("Boxer");
            myAnimals[2] = new Animal("Benjamin");
            myAnimals[3] = new Animal("Snowball");

            foreach(Animal i in myAnimals)
            {
                Console.WriteLine(i.Name);
            }

            // Testing operator overloading
            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(5, 6, 7);
            Box box3 = box1 + box2;

            // Converts the box to a string with ToString()
            Console.WriteLine($"Box 3 : {box3}");
            Console.WriteLine($"Box Int : {(int)box3}");

            // Convert an int into a Box
            Box box4 = (Box)4;

            Console.WriteLine($"Box 4 : {(Box)4}");

            // Sometimes you want to build a simple class that contains fields and
            // Anonymous types are great for that
            var spaceOrk = new { Name = "Space Ork", Price = 24.99 };

            Console.WriteLine("{0} cost ${1}",
                spaceOrk.Name, spaceOrk.Price);

            // Anonymous types can also be stored in an array
            var toyArray = new[] { new {
                Name = "Yu-Gi-Oh Deck", Price = 4.99 },
                new { Name = "Legos", Price = 9.99 } };

            // You can loop through the array
            foreach (var item in toyArray)
            {
                Console.WriteLine("{0} costs ${1}", item.Name, item.Price);
            }

            Console.WriteLine();
        }
    }
}