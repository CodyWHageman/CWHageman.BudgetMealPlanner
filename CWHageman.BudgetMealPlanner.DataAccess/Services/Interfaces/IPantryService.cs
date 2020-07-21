using CWHageman.BudgetMealPlanner.DataAccess.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWHageman.BudgetMealPlanner.DataAccess.Services.Interfaces
{
    public interface IPantryService
    {
        void Add(PantryItemDto meal);
        void Update(PantryItemDto meal);
        void Delete(int id);
        PantryItemDto Get(int id);
        List<PantryItemDto> GetAll();
    }
}
