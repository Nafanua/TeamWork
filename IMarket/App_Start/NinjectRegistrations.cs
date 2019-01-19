using IMarket.BusinessLogic.Services;
using IMarket.BusinessLogic.Services.Abstracts;
using Ninject.Modules;

namespace IMarket
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IStockService>().To<StockService>();
            Bind<IShopService>().To<ShopService>();
        }
    }
}