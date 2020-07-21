using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWHageman.BudgetMealPlanner.Models
{
    [Table("Ingredients")]
    public class Ingredient : Entity
    {
        public int MealId { get; set; }
        public int PantryId { get; set; }
        public int Quantity { get; set; }
    }
}
