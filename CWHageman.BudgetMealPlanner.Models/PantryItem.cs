using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWHageman.BudgetMealPlanner.Models
{
    [Table("PantryItems")]
    public class PantryItem : Entity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }
        public DateTime Expiration { get; set; }
        public decimal PurchasePrice { get; set; }
    }
}
