using System.Text.Json.Serialization;

namespace BStock.Models
{
    public class ReceiptProduct
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get { return UnitPrice * Quantity; } } 
        public string? BodyNotes { get; set; }
        [JsonIgnore]
        public List<Product>? Products { get; set; }
        public int? ReceiptId { get; set; }
        public Receipt? Receipt { get; set; }
    }
}
