using System.Collections;

namespace LINQExamples2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList famAnimals = new ArrayList()
            {
                new Animal{Name = "Heidy", Height = 10, Weight = 10},
                new Animal{Name = "Pongo", Height = 11, Weight = 11},
                new Animal{Name = "Fifi", Height = 12, Weight = 12},
                new Animal{Name = "Jasper", Height = 13, Weight = 13},
            };

            var famAnimalEnum = famAnimals.OfType<Animal>();
        }
    }
}