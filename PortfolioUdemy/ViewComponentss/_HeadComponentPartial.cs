using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.VievComponent
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
