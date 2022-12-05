namespace ThreadCountToExample
{
    internal class Program
    {
        static void CountTo(int maxNum = 1)
        {
            for(int i = 0; i < maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(() => CountTo(10));
            t.Start();

            new Thread(() => { 
            CountTo(5);
            CountTo(6);
            }).Start();
        }
    }
}