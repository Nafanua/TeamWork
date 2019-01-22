using IMarket.BusinessLogic.Services.Abstracts;
using IMarket.DAL;
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
            return View();
        }

        public ActionResult GetStock()
        {
            var model = new StockViewModel
            {
                Items = _stockService.GetProducts(),
                ItemsCount = _stockService.GetCountOfItemsInStock(),
                ItemsWeight = Storage.GetStorageCapacity(),
                MaxWeight = Storage.MaximumStorageCapacity
            };
            return View(model);

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "If you have questions, please let us know:";

            return View();
        }

        public ActionResult GetAllItemsOutOfStock()
        {
            var model = new ProductsNoPlaceInStockViewModel
            {
                ItemsOutOfStock = _stockService.GetProductsNoPlaceInStock()
            };

            return View(model);
        }

        public ActionResult GetAllItemNotFound()
        {
            var model = new ProductsNotFoundViewModel
            {
                ItemsNotFound = _stockService.GetProductsNotFound()
            };

            return View(model);
        }
    }
}