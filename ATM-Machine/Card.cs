using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    internal class Card
    {
        ushort _pin;
        ulong _cardNo;
        string _cardName;
        ushort _cvc;
        Account _account;

        public ushort Pin { get { return _pin; } }
        public ulong CardNo { get { return _cardNo; } }
        public string CardName { get { return _cardName; } }
        public ushort Cvc { get { return _cvc; } }
        public Account Account { get { return _account; } }

        public Card(ushort pin, ulong cardNo, string cardName, ushort cvc, Account account)
        {
            _pin = pin;
            _cardNo = cardNo;
            _cardName = cardName;
            _cvc = cvc;
            _account = account;
        }
    }
}
