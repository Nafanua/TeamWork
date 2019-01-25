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
            return View();
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
                ItemsOutOfStock = _stockService.GetByGroupFromItemNoPlaceInStock()
            };

            return View(model);
        }

        public ActionResult GetAllItemNotFound()
        {
            var model = new ProductsNotFoundViewModel
            {
                ItemsNotFound = _stockService.GetByGroupFromItemNotFound()
            };

            return View(model);
        }

        [HttpGet]
        public JsonResult GetStockJson()
        {
            var items = Storage.GetByGroupFromStorage();

            var result = JsonConvert.SerializeObject(items);

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}