namespace CabInvoiceGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWecome to Cab Invoice Generator Program\n");

            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine("Total fare : " + fare);
        }
    }
}