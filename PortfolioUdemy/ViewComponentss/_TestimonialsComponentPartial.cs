using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponentss
{
    public class _TestimonialsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
}
