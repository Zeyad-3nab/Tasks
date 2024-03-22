using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SavingsAccount:Account
    {
        public double IntRate { get; set; }
        public SavingsAccount()
        {
            IntRate = 3.0;
        }
        public SavingsAccount(string name="No Name" , double balance=0.0 , double intRate = 0.0):base(name,balance)
        {
            IntRate = intRate;
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + IntRate);
        }


    }
}
