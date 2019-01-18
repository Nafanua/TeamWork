using IMarket.BusinessLogic.Services.Abstracts;
using System.Web.Mvc;
using IMarket.Models;

namespace IMarket.Controllers
{
    public class StockController : Controller
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
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
    }
}
