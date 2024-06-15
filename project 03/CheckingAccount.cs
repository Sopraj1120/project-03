using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_03
{
    internal class CheckingAccount:Account
    {
        

        public CheckingAccount(int account, decimal balance, int customerID)
        {
            AccountNumber = account;
            Balance = balance;
            CustomerID = customerID;
        }
    }

  
}
