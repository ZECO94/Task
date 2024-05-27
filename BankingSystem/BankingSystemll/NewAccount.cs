using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace BankingSystemll
{
    enum MenuOptions
    {
        Withdraw,
        Deposite,
        Print,
        Quit
    }
    internal class NewAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }

        

        public NewAccount() { }


        public bool Deposite(decimal amount)
        {
            
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Your Current Balance is : {Balance}");
                return true;
            }
            return false;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                Balance -= amount;
                Console.WriteLine($"Your Current Balance is : {Balance}");
                return true;
            }
            return false;
        }
        public void Print()
        {
            Console.WriteLine($"Your Name : {Name}");
            Console.WriteLine($"Your Balance : {Balance}");

        }
        
        
    }
}
