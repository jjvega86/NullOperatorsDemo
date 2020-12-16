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

            //Null Type
            int? count = null;
            Console.WriteLine(count.HasValue);

            // Null Coalescing
            // Checks to see if left side is null. If null, print what's on the right side.
            //customer1.FirstName = "Ben";
            Console.WriteLine(customer1.FirstName ?? "undefined");

            // Null Conditional
            // Checks to see if customer is null. If it is, return null. Otherwise, return value.
            // Allows a null to be assigned to a value type instead of hitting a null reference exception
            var customerId = mailingList.GetCustomerMailingListId(customer1);
            Console.WriteLine(customerId);
            Console.ReadLine();




        }
    }
}
