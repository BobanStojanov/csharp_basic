using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_SEDC.Classes
{
    public class Address_Class
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }


        public Address_Class(string street, int number, int postalCode, string city)
        {
            Street = street;
            Number = number;
            PostalCode = postalCode;
            City = city;

        }

        public string GetAddress()
        {
            return $"Address";
        }
    }
}
