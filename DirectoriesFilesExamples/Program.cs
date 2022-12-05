namespace DirectoriesFilesExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currentDir = new DirectoryInfo(".");
            DirectoryInfo markDir = new DirectoryInfo(@"C\:Users\mark");
            Console.WriteLine(markDir.FullName);
        }
    }
}