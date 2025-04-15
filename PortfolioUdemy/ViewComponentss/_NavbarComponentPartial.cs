using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.VievComponent
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
