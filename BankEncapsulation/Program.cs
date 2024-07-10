namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount userAccount = new BankAccount();

       

            Console.WriteLine("How much would you like to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            userAccount.Deposit(amountToDeposit);
            userAccount.GetBalance();
            
            Console.WriteLine($"Your current balance is {amountToDeposit,0:c}");
          

        }
    }
}
