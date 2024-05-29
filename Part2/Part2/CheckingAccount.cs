using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class CheckingAccount : Account
    {
        private string name;
        private double balance;
        private const double flatFee = 1.5;

        public CheckingAccount(string name = "Unnamed Account", double balance = 0.0) 
        {
            this.name = name;
            this.balance = balance;

        }
        public new bool Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= (amount + flatFee) ;
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
