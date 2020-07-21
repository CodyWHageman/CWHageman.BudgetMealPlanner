using CWHageman.BudgetMealPlanner.DataAccess.DataTransferObjects;
using CWHageman.BudgetMealPlanner.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWHageman.BudgetMealPlanner.DataAccess.Extensions
{
    public static class PantryItemExtensions
    {
        public static PantryItem ToEntity(this PantryItemDto pantryItemDto)
        {
            return new PantryItem
            {
                Id = pantryItemDto.Id,
                Name = pantryItemDto.Name,
                Quantity = pantryItemDto.Quantity,
                UnitOfMeasure = ParseUnitOfMeasure(pantryItemDto.UnitOfMeasure),
                Expiration = pantryItemDto.Expiration,
                PurchasePrice = pantryItemDto.PurchasePrice
            };
        }

        public static PantryItemDto ToDataTransferObject(this PantryItem pantryItem)
        {
            return new PantryItemDto
            {
                Id = pantryItem.Id,
                Name = pantryItem.Name,
                Quantity = pantryItem.Quantity,
                UnitOfMeasure = pantryItem.UnitOfMeasure.ToString(),
                Expiration = pantryItem.Expiration,
                PurchasePrice = pantryItem.PurchasePrice
            };
        }

        private static UnitOfMeasure ParseUnitOfMeasure(string unitOfMeasureStr)
        {
            var isSuccessful = Enum.TryParse<UnitOfMeasure>(unitOfMeasureStr, out var unitOfMeasure);

            if (!isSuccessful) throw new ArgumentException("Invalid Unit of Measure.");

            return unitOfMeasure;
        }
    }
}
