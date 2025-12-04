using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPS
{
    internal class BankAcc
    {
        private double balance;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(balance < 0)
            {
                Console.WriteLine("InSuffisient Balance");
            }
            else
            {
                balance += amount;
            }
        }
        public double getBalance()
        {
            return balance;
        }
    }
}
