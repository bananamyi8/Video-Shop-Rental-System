namespace Rental.Data
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public bool IsAvailable { get; set; }
    }
}
