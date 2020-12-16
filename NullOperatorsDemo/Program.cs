using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            MailingList mailingList = new MailingList();

            customer1.RegisterCustomer();
            var success = mailingList.SignUpCustomerForMail(customer1) == true ? "Customer added!" : "Uh oh... something happend";
            Console.WriteLine(success);
            

        }
    }
}
