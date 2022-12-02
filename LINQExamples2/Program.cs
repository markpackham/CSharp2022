using System.Collections;

namespace LINQExamples2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal[] animals = new[]
{
                new Animal{Name = "German Shepherd",
                Height = 25,
                Weight = 77,
                AnimalID = 1},
                new Animal{Name = "Chihuahua",
                Height = 7,
                Weight = 4.4,
                AnimalID = 2},
                new Animal{Name = "Saint Bernard",
                Height = 30,
                Weight = 200,
                AnimalID = 3},
                new Animal{Name = "Pug",
                Height = 12,
                Weight = 16,
                AnimalID = 1},
                new Animal{Name = "Beagle",
                Height = 15,
                Weight = 23,
                AnimalID = 2}
            };

            Owner[] owners = new[]
            {
                new Owner{Name = "Doug Parks", OwnerID = 1},
                new Owner{Name = "Sally Smith", OwnerID = 2},
                new Owner{Name = "Paul Brooks", OwnerID = 3}
            };



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


            var animalList = new List<Animal>()
            {
                new Animal{Name = "German Shepherd",
                Height = 25,
                Weight = 77},
                new Animal{Name = "Chihuahua",
                Height = 7,
                Weight = 4.4},
                new Animal{Name = "Saint Bernard",
                Height = 30,
                Weight = 200}
            };

            var animalListEnum = animalList.OfType<Animal>();

            var bigDogs = from dog in animalListEnum
                          where (dog.Weight > 70) && (dog.Height > 25)
                          orderby dog.Name
                          select dog;

            Console.WriteLine("Big Dogs");
            foreach (var dog in bigDogs)
            {
                Console.WriteLine("A {0} weighs {1}lbs", dog.Name, dog.Weight);
            }

        }
    }
}