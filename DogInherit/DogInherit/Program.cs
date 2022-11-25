using DogInherit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogInherit
{
    class Program
    {

        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrrr"
            };


            grover.Sound = "Wooooof";

            whiskers.MakeSound();
            grover.MakeSound();
            whiskers.SetAnimalIDInfo(123, "Jane Jones");
            whiskers.SetAnimalIDInfo(321, "Bill Jones");
            whiskers.GetAnimalIDInfo();
            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11,46));
            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Ooook"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Bow Wow",
                Sound2 = "Arf Arf"
            };
            spot.MakeSound();
           
        }
    }

}