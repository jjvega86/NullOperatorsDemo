using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullOperatorsDemo
{
    class MailingList
    {
        public List<Customer> customersToMail;

        public MailingList()
        {
            customersToMail = new List<Customer>();
        }


        public int? GetCustomerMailingListId(Customer customer)
        {
            // if customer is null, return null. Otherwise, return the MailingId
            // below if statement is the same thing as the final code

            //if (customer == null)
            //{
            //    return null;
            //}

            //return customer.MailingId;

            return customer?.MailingId;
        }
        public void AddCustomerToMailingList(Customer customer)
        {
            customersToMail.Add(GenerateMailingId(customer));

        }
        private Customer GenerateMailingId(Customer customerToAdd)
        {
            Random random = new Random();
            int newMailingId = random.Next(0, 1000000000);

            foreach (Customer customer in customersToMail)
            {
                if (customer.MailingId == newMailingId)
                {
                    GenerateMailingId(customerToAdd);
                }
                else
                {
                    continue;
                }
            }

            return customerToAdd;

        }
    }
}
