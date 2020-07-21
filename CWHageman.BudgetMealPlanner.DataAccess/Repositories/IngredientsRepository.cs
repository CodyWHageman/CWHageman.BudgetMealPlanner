using CWHageman.BudgetMealPlanner.DataAccess.Repositories.Interfaces;
using CWHageman.BudgetMealPlanner.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWHageman.BudgetMealPlanner.DataAccess.Repositories
{
    public class IngredientsRepository : RepositoryBase<Ingredient>, IIngredientsRepository
    {
        public IngredientsRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
