using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    internal class TrustAccount : Account
    {
        private string name;
        private double balance;
        private double interestRate;

    public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double interestRate = 0.0)
        {
            this.name = name;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public new bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                balance += amount;
                if(amount > 5000)
                {
                    balance +=50;
                }
                return true;
            }
        }
        public new bool Withdraw(double amount)
        {
            int counter = 0;
            counter++;
            if (balance - amount >= 0 && counter <3 && amount < (balance*0.2))
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
