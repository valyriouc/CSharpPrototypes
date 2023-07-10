namespace DriverTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver1 = new Driver(
                "Michael",
                "Anton",
                1,
                new Address("Leopoldring", 3, 79199, "Kirchzarten"),
                new DrivingLicense(new DateTime(2013, 4, 13), "Klasse A"));

            Driver driver2 = new Driver(
                "Michaela",
                "Antonella",
                2,
                new Address("Bahnhofstr.", 7, 79108, "Kenzingen"),
                new DrivingLicense(new DateTime(2009, 1, 13), "Klasse B"));

            Console.WriteLine(driver1);
            Console.WriteLine(driver2);
        }
    }
}