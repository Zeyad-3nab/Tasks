namespace Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Ahmed", 200000);
            int x;
            do
            {
                Console.WriteLine("1- Show Details , 2- Deposit , 3- WithDraw");
                int op = int.Parse(Console.ReadLine());
                decimal amount = 0;
                switch (op)
                {
                    case 1:
                        Console.WriteLine(account);
                        break;


                    case 2:
                        Console.WriteLine("Enter the amount of money u want to deposit  ");
                        amount = decimal.Parse(Console.ReadLine());
                        account.Deposit(amount);
                        break;


                    case 3:
                        Console.WriteLine("Enter the amount of money u want to Withdraw  ");
                        amount = decimal.Parse(Console.ReadLine());
                        account.WithDraw(amount);
                        break;

                    default:
                        Console.WriteLine("No Operation");
                        break;
                }
                Console.WriteLine("1- if u want another op");
                Console.WriteLine("any number to exit");
                x = int.Parse(Console.ReadLine());
            } while (x == 1);

            //account.Deposit(5000);
            //account.WithDraw(2000);
            //Console.WriteLine(account);




















        }
    }
}