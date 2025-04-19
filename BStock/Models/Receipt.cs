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

        public List<ReceiptProduct>? Products { get; set; }
        public int TotalAmount => Products.Sum(i => i.TotalPrice);
    }
}
