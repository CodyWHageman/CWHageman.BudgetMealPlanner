using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWHageman.BudgetMealPlanner.Models
{
    [Table("CookDates")]
    public class CookDate : Entity
    {
        public int MealId { get; set; }
        public DateTime Date { get; set; }
    }
}
