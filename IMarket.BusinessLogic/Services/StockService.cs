using IMarket.BusinessLogic.Services.Abstracts;
using IMarket.DAL;
using IMarket.Models.Models;
using System.Collections.Generic;
using IMarket.BusinessLogic.Utils;

namespace IMarket.BusinessLogic.Services
{
    public class StockService : IStockService
    {
        public IEnumerable<ViewModelListItemException> GetByGroupFromItemNoPlaceInStock()
        {
            return Storage.GetByGroupFromItemNoPlaceInStock();
        }

        public IEnumerable<ViewModelListItemException> GetByGroupFromItemNotFound()
        {
            return Storage.GetByGroupFromItemNotFound();
        }

        public int GetCountOfItemsInStock()
        {
            Randomizer.TasksPause();
            var result = Storage.GetCountOfItemsInStock();
            Randomizer.TasksResume();

            return result;
        }

        public IEnumerable<ItemBase> GetProducts()
        {
            Randomizer.TasksPause();
            var result = Storage.GetAll();
            Randomizer.TasksResume();

            return result;
        }

        public IEnumerable<ItemBase> GetProductsNoPlaceInStock()
        {
            Randomizer.TasksPause();
            var result = Storage.GetAllItemsOutOfStock();
            Randomizer.TasksResume();

            return result;
        }

        public IEnumerable<ItemBase> GetProductsNotFound()
        {
            Randomizer.TasksPause();
            var result = Storage.GetAllItemNotFound();
            Randomizer.TasksResume();

            return result;
        }
    }
}
