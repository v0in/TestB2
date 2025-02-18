using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using InventoryAPI.Models; 
using InventoryAPI.Data;    

[Route("api/report")]
[ApiController]
public class ReportController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IConfiguration _configuration;

    public ReportController(AppDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    // Endpoint to fetch products with no warehouse assigned
    [HttpGet("products-no-warehouse")]
    public async Task<IActionResult> GetProductsNoWarehouse()
    {
        var products = await _context.Products
            .Where(p => !_context.StockRecords.Any(sr => sr.ProductId == p.Id))
            .ToListAsync();

        return Ok(products);
    }

    // Endpoint to fetch products with stock less than n in any warehouse
    [HttpGet("products-low-stock")]
    public async Task<IActionResult> GetProductsLowStock()
    {
        // Read the threshold value from appsettings.json
        int lowStockThreshold = _configuration.GetValue<int>("StockSettings:LowStockThreshold");
        var products = await _context.StockRecords
            .Where(sr => sr.Quantity < lowStockThreshold)
            .Select(sr => sr.Product)
            .Distinct()
            .ToListAsync();

        return Ok(products);
    }
}
