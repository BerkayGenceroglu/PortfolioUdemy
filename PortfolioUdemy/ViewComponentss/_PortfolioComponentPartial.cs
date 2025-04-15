using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponentss
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
