using System.Linq;
using IMarket.BusinessLogic.Services.Abstracts;
using IMarket.DAL;
using IMarket.Models.Models;
using System.Web.Mvc;
using IMarket.Models;
using Newtonsoft.Json;

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
                Items = Storage.GetGroupInStorage(),
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

        [HttpGet]
        public JsonResult GetStockJson()
        {
            var items = Storage.GetGroupInStorage();

            var result = JsonConvert.SerializeObject(items);

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}