using System;
using System.Collections.Generic;
using System.Text;

namespace CWHageman.BudgetMealPlanner.DataAccess.DataTransferObjects
{
    public class CookDateDto
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public DateTime Date { get; set; }
    }
}
