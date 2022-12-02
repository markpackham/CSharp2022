using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadLockExample
{
    internal class BankAccount
    {
        private Object acctLock = new Object();
        double Balance { get; set; }

        public BankAccount(double bal)
        {
            Balance = bal;
        }

        public double Withdraw(double amt)
        {
            if ((Balance - amt) < 0)
            {
                Console.WriteLine($"Sorry ${Balance} in Account");
                return Balance;
            }

            lock (acctLock)
            {
                if (Balance >= amt)
                {
                    Console.WriteLine($"Removed {amt} and {(Balance - amt)} left in Account");
                    Balance -= amt;
                }

                return Balance;

            }
        }

        public void IssueWithdraw()
        {
            Withdraw(1);
        }
    }
}
