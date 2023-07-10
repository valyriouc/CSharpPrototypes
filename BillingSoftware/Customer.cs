using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoftware
{
    internal class Customer
    {
        private int customerNumber;
        private string name;
        private string street;
        private int zipCode;
        private string place;

        public Customer(int customerNumber, string name, string street, int zipCode, string place)
        {
            if (zipCode <= 0 || zipCode >= 100000)
            {
                zipCode = 99999;
            }

            this.customerNumber = customerNumber;
            this.name = name;
            this.street = street;
            this.zipCode = zipCode;
            this.place = place;
        }

        public int GetCustomerNumber()
        {
            return customerNumber;
        }

        public string GetName()
        {
            return name;
        }

        public string GetStreet()
        {
            return street;
        }

        public int GetZipCode()
        {
            return zipCode;
        }

        public string GetPlace()
        {
            return place;
        }
    }
}
