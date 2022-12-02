namespace ThreadLockExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(10);

            Thread.CurrentThread.Name = "main";
        }
    }
}