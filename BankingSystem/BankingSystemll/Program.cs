using System.Security.Cryptography.X509Certificates;

namespace BankingSystemll
{
    internal class Program
    {
         static MenuOptions ReadUserOption()
        {
            int selection;
            MenuOptions option;

            do
            {
                Console.WriteLine("Select an option from following : ");
                Console.WriteLine("For Withdraw Press 0");
                Console.WriteLine("For Deposite Press 1");
                Console.WriteLine("For Print Press 2");
                Console.WriteLine("For Quit Press 3");
                Console.WriteLine("=====================");
                Console.Write("Enter Your Selection : ");
                selection = Convert.ToInt32(Console.ReadLine());
                option =(MenuOptions)selection; // Casting to make selection is same in data type with option
            }
            while (0 > selection || selection > 3);
            
            return option;
        }
        public void DoDeposite(NewAccount account)
        {
            Console.Write("Enter A mount you Need : ");
            decimal userInput = decimal.Parse(Console.ReadLine());
            account.Deposite(userInput);

        }

        static void Main(string[] args)
           
            {
            
            NewAccount newAccount1 = new NewAccount() {Name = "Hassan", Balance = 2000};
            NewAccount account = new NewAccount();

            

            MenuOptions option = ReadUserOption();


            switch (option)
                {
                case MenuOptions.Withdraw:
                    Console.WriteLine("You Selected to Withdraw");
                    Console.Write("Enter an Amount to Withdraw : ");
                    decimal yourInput1 = int.Parse(Console.ReadLine());
                    newAccount1.Withdraw(yourInput1);

                break;

                case MenuOptions.Deposite:
                    Console.WriteLine("You Selected to Deposite");
                    Console.Write("Enter an Amount to Deposite : ");
                    decimal yourInput = int.Parse(Console.ReadLine());
                    newAccount1.Deposite(yourInput);
                    
                break;

                case MenuOptions.Print:
                    Console.WriteLine("You Selected to Print");
                    newAccount1.Print();
                break;

                case MenuOptions.Quit:
                    Console.WriteLine("Good Bye !");
                return;
                }
            }

        
    }
}
