﻿using IMarket.BusinessLogic.Services.Abstracts;
using IMarket.Models;
using System.Web.Mvc;

namespace IMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStockService _stockService;

        public HomeController(IStockService stockService)
        {
            _stockService = stockService;
        }

        public ActionResult Index()
        {
            var model = new StockViewModel
            {
                Items = _stockService.GetProducts(),
                ItemsCount = _stockService.GetCountOfItemsInStock()
            };
            return View(model);

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetAllItemsOutOfStock()
        {
            var model = new StockViewModel
            {
                ItemsOutOfStock = _stockService.GetProductsOutOfStock()
            };

            return View(model);
        }

        public ActionResult GetAllItemNotFound()
        {
            var model = new StockViewModel
            {
                ItemsNotFound = _stockService.GetProductsNotFound()
            };

            return View(model);
        }
    }
}