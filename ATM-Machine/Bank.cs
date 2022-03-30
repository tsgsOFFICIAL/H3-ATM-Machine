using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    public class Bank
    {
        List<Customer> _customers = new List<Customer>();
        List<ATM> _atms = new List<ATM>();

        public List<ATM> Atms
        {
            get { return _atms; }
        }

        public List<Customer> Customers
        {
            get { return _customers; }
        }

        public ATM CreateATM()
        {
            ATM atm = new ATM();

            _atms.Add(atm);

            return atm;
        }

        public Customer CreateCustomer(string name)
        {
            Customer customer = new Customer(name);

            _customers.Add(customer);

            return customer;
        }
    }
}
