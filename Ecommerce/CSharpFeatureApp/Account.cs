using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public  class Account
    {
        public event Operation underBalance;
        public event Operation overBalance;

        public double Balance { get; set; }
        public Account(double initialAmount)
        {
            Balance= initialAmount;
        }
        public void Withdraw(double amount)
        {
            double result = Balance - amount;
            if(result<=10000)
            {
                underBalance(5);//raise an event:underBalance
            }
            Balance = result; ;
        }
        public void Deposit(double amount) 
        {
            Balance += amount;
            if(Balance>=250000)
            {
                overBalance(15); //raise an event: overBalance
            }
        }
    }
}
