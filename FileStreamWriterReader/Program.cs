namespace FileStreamWriterReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"E:\Sites\deleteMe\testFile3.txt";
            StreamWriter sw = new StreamWriter(textFilePath);
            sw.Write("This is a random ");
            sw.Write(" yep 100% totally random ");
            sw.WriteLine("sentance. With new line.");
            sw.WriteLine("A new line has been written.");
            sw.Close();
        }
    }
}