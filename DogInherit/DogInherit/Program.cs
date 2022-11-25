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

           
        }
    }

}