using System.Text;

namespace FileStreamExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"E:\Sites\deleteMe\testFile2.txt";
            FileStream fs = File.Open(textFilePath, FileMode.Create);
            string randString = "This is a random string";
            // covner to byte array
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            fs.Write(rsByteArray, 0, rsByteArray.Length);
            fs.Position= 0;

            byte[] fileByteArray = new byte[rsByteArray.Length];

            for(int i =0; i<rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            fs.Close();
        }
    }
}