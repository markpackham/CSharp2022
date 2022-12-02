namespace ThreadLockExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(10);

            Thread.CurrentThread.Name = "main";
            Thread[] threads = new Thread[15];

            for (int i= 0; i<15; i++)
            {
                Thread t = new Thread(new ThreadStart(account.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }
        }
    }
}