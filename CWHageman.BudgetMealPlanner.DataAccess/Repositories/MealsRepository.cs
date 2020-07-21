using CWHageman.BudgetMealPlanner.DataAccess.Repositories.Interfaces;
using CWHageman.BudgetMealPlanner.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CWHageman.BudgetMealPlanner.DataAccess.Repositories
{
    public class MealsRepository : RepositoryBase<Meal>, IMealsRepository
    {
        public MealsRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
