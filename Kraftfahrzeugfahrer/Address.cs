using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverTask
{
    internal class Address
    {
        private string street;
        private int houseNumber;
        private int zipCode;
        private string location;

        public Address(string street, int houseNumber, int zipCode, string location)
        {
            this.street = street;
            this.houseNumber = houseNumber;
            this.zipCode = zipCode;
            this.location = location;
        }

        public override string ToString()
        {
            return $"Street: {street}\nHouse number: {houseNumber}\nZip code: {zipCode}\nLocation: {location}";
        }

        public string GetStreet()
        {
            return street;
        }

        public int GetHouseNumber()
        {
            return houseNumber;
        }

        public int GetZipCode()
        {
            return zipCode;
        }

        public string GetLocation()
        {
            return location;
        }
    }
}
