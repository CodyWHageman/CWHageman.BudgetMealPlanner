using CWHageman.BudgetMealPlanner.DataAccess.Repositories.Interfaces;
using CWHageman.BudgetMealPlanner.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWHageman.BudgetMealPlanner.DataAccess.Repositories
{
    public class CookDatesRepository : RepositoryBase<CookDate>, ICookDatesRepository
    {
        public CookDatesRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
