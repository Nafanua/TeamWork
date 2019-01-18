using IMarket.BusinessLogic.Services.Abstracts;
using IMarket.DAL;
using IMarket.Models.Models;
using System.Collections.Generic;

namespace IMarket.BusinessLogic.Services
{
    public class StockService : IStockService
    {
        public int GetCountOfItemsInStock()
        {
            return Storage.GetCountOfItemsInStock();
        }

        public IEnumerable<ItemBase> GetProducts()
        {
            return Storage.GetAll();
        }

        public IEnumerable<ItemBase> GetProductsOutOfStock()
        {
            return Storage.GetAllItemsOutOfStock();
        }

        public IEnumerable<ItemBase> GetProductsNotFound()
        {
            return Storage.GetAllItemNotFound();
        }
    }
}
