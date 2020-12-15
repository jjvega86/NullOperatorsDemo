using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullOperatorsDemo
{
    class Customer
    {
        private string firstName;
        private string lastName;
        private int? customerId;
        private List<Customer> customers;

        public string FirstName { get => firstName; }
        public string LastName { get => lastName; }
        public int? CustomerId { get => customerId; set => customerId = value ?? GenerateCustomerId(); }

        public Customer()
        {
            customers = new List<Customer>();
        }

        

        public int GenerateCustomerId()
        {
            Random random = new Random();
            int newCustomerId = random.Next(0, 1000000000);

            foreach(Customer customer in customers)
            {
                if (customer.customerId == newCustomerId)
                {
                    GenerateCustomerId();
                }
                else
                {
                    continue;
                }
            }

            return newCustomerId;

        }
    }
}
