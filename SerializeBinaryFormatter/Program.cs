using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializeBinaryFormatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal bowser = new Animal("Bowser",400,20,1);
            // File created here E:\Sites\CSharp2022\SerializeBinaryFormatter\bin\Debug\net6.0
            Stream stream = File.Open("AnimalData.dat", FileMode.Create);
            BinaryFormatter formatter= new BinaryFormatter();
            formatter.Serialize(stream, bowser);
            stream.Close();

            // delete data by turning it to null
            bowser = null;

            stream = File.Open("AnimalData.dat", FileMode.Open);
            formatter = new BinaryFormatter();

            bowser = (Animal)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine(bowser.ToString());

            bowser.AnimalID= 11111;
            bowser.Name = "Bowser von Changed Name III";

            string filePath = @"E:\Sites\bowser.xml";
            XmlSerializer serializer= new XmlSerializer(typeof(Animal));
            using (TextWriter tw = new StreamWriter(filePath))
            {
                serializer.Serialize(tw, bowser);
            }

            bowser = null;

            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(filePath);
            object obj = deserializer.Deserialize(reader);
            bowser = (Animal)obj;
            reader.Close();

            Console.WriteLine(bowser.ToString());

            string filePathAnimals = @"E:\Sites\animals.xml";
            List<Animal> theAnimals = new List<Animal>()
            {
                new Animal("Horse", 60, 30, 22),
                new Animal("Mule", 55, 24, 33),
                new Animal("Donkey", 40, 20, 44)
            };

            using (Stream fileStream = new FileStream(filePathAnimals, FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                serializer2.Serialize(fileStream, theAnimals);
            }

            theAnimals = null;

            XmlSerializer deserializer2 = new XmlSerializer(typeof(List<Animal>));

            using (FileStream fileStream2 = File.OpenRead(filePathAnimals))
            {
                theAnimals = (List<Animal>)deserializer2.Deserialize(fileStream2);
            }

            foreach (Animal animal in theAnimals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}