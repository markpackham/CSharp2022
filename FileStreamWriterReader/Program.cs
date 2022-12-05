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
            sw.WriteLine("A new line has been written.");
            sw.WriteLine("A new line has been written.");
            sw.WriteLine("A new line has been written.");
            sw.Close();

            StreamReader sr = new StreamReader(textFilePath);
            // Peek: T
            Console.WriteLine($"Peek : {Convert.ToChar(sr.Peek())}");
            // 1st String This is a random  yep 100% totally random sentance. With new line.
            Console.WriteLine($"1st String {sr.ReadLine()}");
            Console.WriteLine($"Everything else: {sr.ReadToEnd()}");
            sr.Close();
        }
    }
}