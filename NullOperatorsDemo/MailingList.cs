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

        public int GenerateCustomerId()
        {
            Random random = new Random();
            int newMailingId = random.Next(0, 1000000000);

            foreach (Customer customer in customersToMail)
            {
                if (customer.MailingId == newMailingId)
                {
                    GenerateCustomerId();
                }
                else
                {
                    continue;
                }
            }

            return newMailingId;

        }
    }
}
