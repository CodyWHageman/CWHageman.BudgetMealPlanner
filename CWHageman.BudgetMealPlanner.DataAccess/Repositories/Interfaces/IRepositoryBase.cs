using CWHageman.BudgetMealPlanner.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWHageman.BudgetMealPlanner.DataAccess.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {
        List<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
