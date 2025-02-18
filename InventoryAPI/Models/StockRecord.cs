namespace InventoryAPI.Models
{
    public class StockRecord
    {
        public int Id { get; set; }
        
        // Foreign keys
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        
        // Navigation properties
        public Product? Product { get; set; }
        public Warehouse? Warehouse { get; set; }
        
        public int Quantity { get; set; }
    }
}
