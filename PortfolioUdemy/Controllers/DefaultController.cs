using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
