using System;

namespace CWHageman.BudgetMealPlanner.DataAccess.DataTransferObjects
{
    public class PantryItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public DateTime Expiration { get; set; }
        public decimal PurchasePrice { get; set; }
    }
}
