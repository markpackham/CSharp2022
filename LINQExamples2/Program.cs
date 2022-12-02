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
                new Animal{Name = "Rover", Height = 14, Weight = 14},
                new Animal{Name = "Dumbo", Height = 15, Weight = 15},
            };

            var famAnimalEnum = famAnimals.OfType<Animal>();

            var smAnimals = from animal in famAnimalEnum
                            where animal.Weight<=12
                            orderby animal.Name
                            select animal;

            Console.WriteLine("Animals that weight 12k of less");
            foreach (var animal in smAnimals )
            {
                Console.WriteLine($"{animal.Name} weights {animal.Weight}kg");
            }
        }
    }
}