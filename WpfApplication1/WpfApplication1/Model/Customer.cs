using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Model
{
    public class Customer
    {
        public Customer()
        {

        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Adress { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public double Value { get; set; }
    }
}
