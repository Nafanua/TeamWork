using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMarket.BusinessLogic.Services.Abstracts;
using IMarket.DAL;
using IMarket.Models.Models;

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
