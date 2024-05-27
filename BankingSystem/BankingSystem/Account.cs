using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    //Part 1 :
 public class Account
    {

        private string name;
        private decimal balance;
        
        //PART1
        public Account(string name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
            
        }
        public void Deposite(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Your Current Balane is : {balance}");
        }
        public void Withdraw(decimal amount)
        {
            balance -= amount;
            Console.WriteLine($"Your Current Balane is : {balance}");
        }
        public void Print()
        {
            Console.WriteLine($"Your Name is : {name}");
            Console.WriteLine($"Your Balance is :  {balance} ");
        }
     }

              
 }
     









 