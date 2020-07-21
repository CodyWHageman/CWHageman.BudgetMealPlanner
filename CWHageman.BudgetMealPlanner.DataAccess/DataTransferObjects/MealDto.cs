using System.Collections.Generic;

namespace CWHageman.BudgetMealPlanner.DataAccess.DataTransferObjects
{
    public class MealDto
    {
        public int Id { get; set; }
        public bool HasLeftovers { get; set; }
        public bool IsKidFriendly { get; set; }
        public int CookTime { get; set; }
        public List<IngredientDto> Ingredients { get; set; }
    }
}
