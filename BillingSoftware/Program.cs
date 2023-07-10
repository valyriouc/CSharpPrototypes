namespace BillingSoftware
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Max Mustermann", "Musterstr. 10", 73233, "Musterstadt");
            SingleLicense license1 = new SingleLicense(30, "Test1", 40.5);
            VolumeLicense license2 = new VolumeLicense(10, 3, "Test2", 25.2);
            Check check = new Check(customer);
            check.SetArticle(license1);
            check.SetArticle(license2);
            check.Print();
        }
    }
}