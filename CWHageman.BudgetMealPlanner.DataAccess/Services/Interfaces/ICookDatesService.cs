using CWHageman.BudgetMealPlanner.DataAccess.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWHageman.BudgetMealPlanner.DataAccess.Services.Interfaces
{
    public interface ICookDatesService
    {
        void Add(CookDateDto meal);
        void Update(CookDateDto meal);
        void Delete(int id);
        CookDateDto Get(int id);
        List<CookDateDto> GetByMonth(int month);
    }
}
