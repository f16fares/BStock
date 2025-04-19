using BStock.Data;
using BStock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController (StockDbContext context) : ControllerBase
    {
        private readonly StockDbContext _context = context;
        [HttpPost]
        public async Task<IActionResult> CreateReceipt([FromBody] ReceiptProduct dto)
        {
            var receipt = new Receipt
            {
                MarketName = "Mark",
                Location = "Place",
                Contact = "0000000000",
                ReleaseDate = DateTime.Now,
                Products = dto.Products.Select(i => new ReceiptProduct
                {
                    ProductName = dto.ProductName,
                    Quantity = dto.Quantity,
                    UnitPrice = dto.UnitPrice,
                }).ToList()
            };

            _context.Receipts.Add(receipt);
            await _context.SaveChangesAsync();

            return Ok(receipt);
        }

        [HttpGet("Id")]
        public async Task<ActionResult<List<Receipt>>> GetReceiptById(int id)
        {
            var receipt = await _context.Receipts.FindAsync(id);
            if (receipt == null) 
            {
                return NotFound();
            }
            return Ok(receipt);
        }

    }
}
