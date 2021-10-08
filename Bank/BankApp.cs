using System;

namespace Bank
{
    public class BankApp
    {
        public double Balance { get; set; }

        public double Deposit (double Amount , double Balance)
        { 
            if (Amount>0)
            {
                Balance += Amount;
                
            }
            return Balance;
        }

        public double Withdraw(double Amount, double Balance)
        {
            if (Balance- Amount > 0)
            {
                Balance -= Amount;
                
            }
            return Balance;
        }
    }
}
