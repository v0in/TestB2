using InventoryAPI.Data;
using InventoryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockRecordController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StockRecordController(AppDbContext context)
        {
            _context = context;
        }

        // GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StockRecord>>> GetStockRecords([FromQuery] string? search)
        {
            var query = _context.StockRecords
                .Include(sr => sr.Product)
                .Include(sr => sr.Warehouse)
                .AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                string lowerSearch = search.ToLower(); 
                query = query.Where(sr => sr.Product.Name.ToLower().Contains(lowerSearch));
            }

            var stockRecords = await query.ToListAsync();
            return Ok(stockRecords);
        }

        // POST
        [HttpPost]
        public async Task<ActionResult<StockRecord>> CreateStockRecord(StockRecord stockRecord)
        {
            _context.StockRecords.Add(stockRecord);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetStockRecords), stockRecord);
        }

        // PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStockRecord(int id, StockRecord stockRecord)
        {
            if (id != stockRecord.Id) return BadRequest();
            _context.Entry(stockRecord).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStockRecord(int id)
        {
            var stockRecord = await _context.StockRecords.FindAsync(id);
            if (stockRecord == null) return NotFound();
            _context.StockRecords.Remove(stockRecord);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
