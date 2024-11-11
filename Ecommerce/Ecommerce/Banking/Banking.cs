namespace Banking
{
    public class Bank
    {
        public event Operation underBalance;
        public event Operation overBalance;

        public double Balance { get; set; }
        public Bank(double initialAmount)
        {
            Balance = initialAmount;
        }
        public void Withdraw(double amount)
        {
            double result = Balance - amount;
            if (result <= 10000)
            {
                underBalance(5);//raise an event:underBalance
            }
            Balance = result; ;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
            if (Balance >= 250000)
            {
                overBalance(15); //raise an event: overBalance
            }
        }
    }
}
}
