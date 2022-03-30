using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    internal class Customer
    {
        List<Account> _accounts = new List<Account>();
        string _name;

        public List<Account> Accounts
        {
            get { return _accounts; }
        }

        public string Name
        {
            get { return _name; }
        }

        public Customer(string name)
        {
            _name = name;
        }

        internal Account CreateAccount(decimal balance)
        {
            Account account = new Account(this, balance);

            _accounts.Add(account);

            return account;
        }

        internal Account CreateAccount(string name, decimal balance)
        {
            Account account = new Account(this, name, balance);

            _accounts.Add(account);

            return account;
        }

        internal List<Account> GetAccounts()
        {
            return _accounts;
        }

        internal string GetName()
        {
            return _name;
        }
    }
}
