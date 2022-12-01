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
        }
    }
}