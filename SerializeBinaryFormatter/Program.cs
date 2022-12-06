﻿using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializeBinaryFormatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal bowser = new Animal("Bowser",40,20);
            Stream stream = File.Open("AnimalData.dat", FileMode.Create);
            BinaryFormatter formatter= new BinaryFormatter();
            formatter.Serialize(stream, bowser);
            stream.Close();

            bowser = null;

            stream = File.Open("AnimalData.dat", FileMode.Open);
            formatter = new BinaryFormatter();

            bowser = (Animal)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine(bowser.ToString());
        }
    }
}