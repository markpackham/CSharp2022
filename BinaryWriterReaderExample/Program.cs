namespace BinaryWriterReaderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"E:\Sites\deleteMe\textFile4";

            // We use Binary Readers and Writers to handle data types
            FileInfo dataFile= new FileInfo(textFilePath);
            BinaryWriter bw = new BinaryWriter(dataFile.OpenWrite());
            string randomText = "Random string text";
            int myAge = 20;
            double height = 6.3;
            bw.Write(randomText);
            bw.Write(myAge);
            bw.Write(height);
            bw.Close();

            BinaryReader br = new BinaryReader(dataFile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            br.Close();
        }
    }
}