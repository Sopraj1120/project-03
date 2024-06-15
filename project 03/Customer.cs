using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_03
{
    internal class Customer
    {
       public int CustomerId;
       public string Name;
       public string Email;
       public List<Account> Accounts;



        public Customer() { }   

        public Customer(int customerId, string name, string email, List<Account> accounts)
        {
            CustomerId = customerId;
            Name = name;
            Email = email;
            Accounts = accounts;
        }

        public void AddAccount(Account account )
        {
            Accounts.Add(account);
        }
        public void RemoveAccount(Account account)
        {
            Accounts.Remove(account);
        }
        public List<Account> GetAccountDetails()
        {
            return Accounts;
        }

    }
   
}
