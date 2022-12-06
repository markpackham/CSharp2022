using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializeBinaryFormatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal boweser= new Animal("Bowser",40,20);
            Stream stream = File.Open("AnimalData.dat", FileMode.Create);
            BinaryFormatter formatter= new BinaryFormatter();
            formatter.Serialize(stream, boweser);
            stream.Close();
        }
    }
}