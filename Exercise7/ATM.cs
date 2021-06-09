using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class ATM
    {
        private decimal Amount = 1000m;
        public void CheckBalance()
        {
            Console.WriteLine(Amount);
        }
        public void Withdraw(decimal money)
        {
            decimal newAmount = Math.Round(this.Amount - money, 2);
            if(newAmount < 0)
            {
                Console.WriteLine($"Invalid Transaction. Select other options or enter an amount less than {this.Amount}!!!");
            }
            else
            {
                this.Amount = newAmount;
            }
        }
        public void Deposit(decimal money)
        {
            this.Amount = Math.Round(this.Amount + money, 2);
        }
    }
}
