namespace DirectoriesFilesExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currentDir = new DirectoryInfo(".");
            DirectoryInfo markDir = new DirectoryInfo(@"E:\Sites");
            Console.WriteLine(markDir.FullName);
            Console.WriteLine(markDir.Name);
            Console.WriteLine(markDir.Parent);
            Console.WriteLine(markDir.Attributes);
            Console.WriteLine(markDir.CreationTime);

            DirectoryInfo dataDir = new DirectoryInfo(@"E:\Sites\deleteMe");
            dataDir.Create();
            //Directory.Delete(@"E:\Sites\deleteMe");
            dataDir.Delete();

        }
    }
}