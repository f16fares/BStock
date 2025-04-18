namespace BStock.Models
{
    public class Receipt
    {
        // Receipt Header

        public int Id { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? HeaderNotes { get; set; }
        public string? MarketName { get; set; }
        public string? Location { get; set; }
        public string? Contact { get; set; }

        // Receipt Body

        public List<Product>? Products { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get { return UnitPrice * Quantity; } }
        public string? BodyNotes { get; set; }
    }
}
