using BStock.Data;
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
        

    }
}
