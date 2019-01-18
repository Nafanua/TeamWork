using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMarket.BusinessLogic.Services.Abstracts;
using IMarket.Models;

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
            return View();
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

            return View();
        }

        public ActionResult GetAllItemNotFound()
        {
            var model = new StockViewModel
            {
                ItemsNotFound = _stockService.GetProductsNotFound()
            };

            return View();
        }
    }
}