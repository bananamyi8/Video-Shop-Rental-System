namespace Rental.Data
{
    public class Payment
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public float Amount { get; set; }
        public int NumberOfCopies { get; set; }
        public float TotalPayment { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
