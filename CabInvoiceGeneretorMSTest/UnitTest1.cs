using CabInvoiceGenerator;

namespace CabInvoiceGeneretorMSTest
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenerator invoiceGenerator = null;

        //UC1 Calculate total fare
        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

            double distance = 2.0;
            int time = 5;

            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);
        }
    }
}