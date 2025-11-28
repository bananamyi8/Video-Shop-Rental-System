namespace Rental.Data
{
    public class Rental
    {
        public int Id { get; set; }
        public string CostumerName { get; set; }
        public string NumberOfCopies { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
