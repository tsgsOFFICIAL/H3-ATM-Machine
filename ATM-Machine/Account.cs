using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    internal class Account
    {
        Card _card;
        decimal _balance;
        string? _accountName;

        public Card Card
        {
            get { return _card; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public string Name
        {
            get { return _accountName ?? ""; }
        }

        public Account(Customer customer, string accountName, decimal balanace)
        {
            _card = GenerateCard(customer.GetName());
            _accountName = accountName;
            _balance = balanace;
        }

        public Account(Customer customer, decimal balanace)
        {
            _card = GenerateCard(customer.GetName());
            _balance = balanace;
        }

        internal Card GenerateCard(string name)
        {
            Card card = new Card(
                (ushort)new Random().Next(1000, 9999 + 1),
                (ulong)new Random().NextInt64(1000000000000000, 9999999999999999 + 1),
                name,
                (ushort)new Random().Next(100, 999 + 1),
                this
                );

            return card;
        }

        internal string? GetAccountName()
        {
            return _accountName;
        }
    }
}
