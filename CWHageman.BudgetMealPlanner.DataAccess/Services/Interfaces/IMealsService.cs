using CWHageman.BudgetMealPlanner.DataAccess.DataTransferObjects;
using CWHageman.BudgetMealPlanner.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWHageman.BudgetMealPlanner.DataAccess.Services.Interfaces
{
    public interface IMealsService
    {
        void Add(MealDto meal);
        void Update(MealDto meal);
        void Delete(int id);
        MealDto Get(int id);
        List<MealDto> GetAll();
    }
}
