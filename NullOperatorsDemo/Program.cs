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

            // Null Coalescing
            // Checks to see if left side is null. If null, print what's on the right side.
            //customer1.FirstName = "Ben";
            Console.WriteLine(customer1.FirstName ?? "undefined");
            Console.ReadLine();




        }
    }
}
