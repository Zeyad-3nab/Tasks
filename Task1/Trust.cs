using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Trust:Account
    {
        public double IntRate { get; set; }
        public Trust()
        {
            IntRate = 3.0;
        }
        public Trust(string name ="NoName", double balance=0.0, double intRate = 0.0) : base(name, balance)
        {
            IntRate = intRate;
        }
        public override bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else if(amount >5000)
            {
                base.Deposit(amount+50);
                return true;
            }
            else
            {
                base.Deposit(amount);
                return true;
            }
        }
         int count = 0;
        public override bool Withdraw(double amount)
        {
          if(count < 3)
          {
                if (balance - amount >= 0)
                {
                    if ((balance * 20 / 100) >= amount)
                    {
                        count++;
                        balance -= amount;
                        return true;
                    }
                    else
                        return false;
                }
                else
                {
                    return false;
                }
          }
            else
            {
                return false;
            }
        }


    }
}
