namespace ThreadExamples
{
    internal class Program
    {
        static void Print1()
        {
            for(int i=0; i<1000; i++)
            {
                Console.Write(1);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(Print1);
            // Threads share resources so you can never fully predict when one will start
            t.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }
        }
    }
}