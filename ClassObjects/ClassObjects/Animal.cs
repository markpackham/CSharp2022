using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects
{
    class Animal
    {
        public string name;
        public string sound;
        static int numOfAnimals = 0;

        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name")
        {
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name", string sound = "No Sound")
        {
            this.name = name;
            this.sound= sound;
            numOfAnimals++;
        }
    }
}
