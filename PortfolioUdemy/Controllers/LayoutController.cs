using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
