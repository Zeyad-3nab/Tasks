using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Account
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public Account(string name="No Name",decimal balance=0)
        {
            Name = name;
            Balance = balance;
        }


        public void WithDraw(decimal amount)
        {
            if(amount<=Balance&&amount>0)
            {
                Balance-=amount;
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine("Your Balanceis not enough");
            }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine("Done");

        }


        public override string ToString()
        {
            return $"Name = {Name} , Balance = {Balance}";
        }
    }
}
