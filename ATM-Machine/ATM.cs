using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    public class ATM
    {
        public bool Deposit(Card card, decimal amount)
        {
            if (amount <= 0)
                return false;

            try
            {
                card.Account.Balance += amount;
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Withdraw(Card card, decimal amount)
        {
            if (amount <= 0)
                return false;

            if (card.Account.Balance - amount >= 0)
            {
                card.Account.Balance -= amount;
                return true;
            }
            else
            {
                throw new ArgumentOutOfRangeException("You are not able to withdraw this amount");
            }
        }
    }
}
