using static System.Collections.Specialized.BitVector32;

namespace BStock.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int Price { get; set; }
        public string? Notes { get; set; }
        public int? SectionId { get; set; }
        public Section? Section { get; set; }
    }
}
