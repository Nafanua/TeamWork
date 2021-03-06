﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMarket.Models.Models;

namespace IMarket.BusinessLogic.Services.Abstracts
{
    public interface IStockService
    {
        int GetCountOfItemsInStock();
        IEnumerable<ItemBase> GetProducts();
        IEnumerable<ItemBase> GetProductsOutOfStock();
        IEnumerable<ItemBase> GetProductsNotFound();
    }
}
