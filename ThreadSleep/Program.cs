namespace ThreadSleep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);
                Thread.Sleep(1000);
                num++;
            }
            Console.WriteLine("Thread Ended");
        }
    }
}