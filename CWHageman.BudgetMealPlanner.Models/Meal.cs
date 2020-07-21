using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWHageman.BudgetMealPlanner.Models
{
    [Table("Meals")]
    public class Meal : Entity
    {
        public bool HasLeftovers { get; set; }
        public bool IsKidFriendly { get; set; }
        public int CookTime { get; set; }
    }
}
