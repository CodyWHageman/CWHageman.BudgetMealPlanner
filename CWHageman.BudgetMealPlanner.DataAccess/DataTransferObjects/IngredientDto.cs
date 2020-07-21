using System;
using System.Collections.Generic;
using System.Text;

namespace CWHageman.BudgetMealPlanner.DataAccess.DataTransferObjects
{
    public class IngredientDto
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public int PantryId { get; set; }
        public int Quantity { get; set; }
    }
}
