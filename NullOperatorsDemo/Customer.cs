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
        private int? mailingId;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int? MailingId { get => mailingId; set => mailingId = value; }

        

       
    }
}
