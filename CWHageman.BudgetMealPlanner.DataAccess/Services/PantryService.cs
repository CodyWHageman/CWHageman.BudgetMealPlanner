using CWHageman.BudgetMealPlanner.DataAccess.DataTransferObjects;
using CWHageman.BudgetMealPlanner.DataAccess.Extensions;
using CWHageman.BudgetMealPlanner.DataAccess.Repositories.Interfaces;
using CWHageman.BudgetMealPlanner.DataAccess.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CWHageman.BudgetMealPlanner.DataAccess.Services
{
    public class PantryService : IPantryService
    {
        private readonly IPantryRepository _pantryRepository;

        public PantryService(IPantryRepository pantryRepository)
        {
            _pantryRepository = pantryRepository;
        }

        public void Add(PantryItemDto pantryItemDto)
        {
            var pantryItemEntity = pantryItemDto.ToEntity();

            _pantryRepository.Add(pantryItemEntity);
        }

        public void Update(PantryItemDto pantryItemDto)
        {
            var pantryItemEntity = pantryItemDto.ToEntity();

            _pantryRepository.Update(pantryItemEntity);
        }
        public void Delete(int id)
        {
            _pantryRepository.Delete(id);
        }

        public PantryItemDto Get(int id)
        {
            return _pantryRepository.Get(id).ToDataTransferObject();
        }

        public List<PantryItemDto> GetAll()
        {
            return _pantryRepository.GetAll().Select(p => p.ToDataTransferObject()).ToList();
        }
    }
}
