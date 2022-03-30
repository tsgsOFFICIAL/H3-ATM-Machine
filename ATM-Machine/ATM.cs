using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    internal class ATM
    {
        internal void Deposit(Card card, decimal amount)
        {
            try
            {
                card.Account.Balance += amount;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        internal void Withdraw(Card card, decimal amount)
        {
            if (card.Account.Balance - amount >= 0)
            {
                card.Account.Balance -= amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException("You are not able to withdraw this amount");
            }
        }
    }
}
