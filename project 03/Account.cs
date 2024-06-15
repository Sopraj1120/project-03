using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_03
{
    internal class Account
    {
        public int AccountNumber;
        public decimal Balance;
        public int CustomerID;

        public Account() { }

        public Account(int accountNumber, int balance, int ustomerID)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            CustomerID = ustomerID;
        }
        public void Deposit(decimal amount)
        {
            Balance = amount + Balance;
        }
        public void Withdraw(decimal amount)
        {
            if (Balance+1500 > amount) {
                Balance = Balance - amount;
            }

            
        }
        public void Withdraw(double percentage)
        {
            Balance = Balance - (Balance * Convert.ToDecimal(percentage));
            
        }
        public decimal GetBalance()
        {
            return Balance;    
        }
    }


}
