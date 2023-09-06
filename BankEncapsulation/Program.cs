namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            bool isInAtm = false;
            while (!isInAtm)
            {
                Console.WriteLine("press 0 to see balance: press 1 to deposit: press 2 to withdraw");
                int chose = int.Parse(Console.ReadLine());
                if (chose == 0)
                {

                    Console.WriteLine($"You have {account.GetBalance()}");
                }
                if (chose == 1)
                {
                    Console.WriteLine("how much will you deposit");
                    double addingNum = double.Parse(Console.ReadLine());
                    account.Deposit(addingNum);
                }
                if (chose == 2)
                {
                    Console.WriteLine("how much will you withdraw");
                    double subtractNum = double.Parse(Console.ReadLine());
                    account.Withdraw(subtractNum);
                }
                if (chose == 3)
                {
                    isInAtm = true;
                }
            }
            
        }
    }
}

