using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponentss
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
