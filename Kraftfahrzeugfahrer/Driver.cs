
namespace DriverTask
{
    internal class Driver
    {
        private string firstName;
        private string lastName;
        private int personalNumber;
        private Address address;
        private DrivingLicense license;

        public Driver(string firstName, string lastName, int personalNumber, Address address, DrivingLicense license)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.personalNumber = personalNumber;
            this.address = address;
            this.license = license;
        }

        public override string ToString()
        {
            return $"Name: {firstName} {lastName}\nPersonal Number: {personalNumber}\nAddress:\n{address}\nDriving license:\n{license}";
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public int GetPersonalNumber()
        {
            return personalNumber;
        }

        public Address GetAddress()
        {
            return address;
        }

        public DrivingLicense GetDrivingLicense()
        {
            return license;
        }

        public void SetAddress(Address address)
        {
            this.address = address;
        }
    }
}
