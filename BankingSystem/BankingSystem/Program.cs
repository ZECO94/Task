namespace BankingSystem
{
    
    internal class Program
    {
    

        static void Main(string[] args)
        {
            Account account1 = new Account("Ayman" , 8000);
            account1.Print();
            Console.Write("Enter deposited Value : ");
            decimal yourInput = decimal.Parse(Console.ReadLine());
            account1.Deposite(yourInput);
            Console.WriteLine($"You added {yourInput} to your Account");
            account1.Print();
            Console.Write("Enter Withdraw Value : ");
            decimal yourInput2 = decimal.Parse(Console.ReadLine());
            account1.Withdraw(yourInput2);
            Console.WriteLine($"You withdrew {yourInput2} to your Account");
            account1.Print();


        }
    }
}
