using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_03
{
    internal class SavingAccount:Account
    {
        public int AccountNumber;
        public decimal Balance;
        public int CustomerID;


        public SavingAccount(int accountNumber, decimal balance, int customerID)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            CustomerID = customerID;
        }   
    }
}
