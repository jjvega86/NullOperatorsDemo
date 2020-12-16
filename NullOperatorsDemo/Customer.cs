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
        private int? mailingId = null;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int? MailingId { get => mailingId; set => mailingId = value; }

        public void RegisterCustomer()
        {
            Console.WriteLine("Please enter your First Name!");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your Last Name!");
            lastName = Console.ReadLine();
        }
        

       
    }
}
