using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponentss
{
    public class _FooterComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
