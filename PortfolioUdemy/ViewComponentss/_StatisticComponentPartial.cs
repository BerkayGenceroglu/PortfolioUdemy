using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponentss
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
