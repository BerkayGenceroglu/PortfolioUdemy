using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.Context;

namespace PortfolioUdemy.ViewComponentss
{
    public class _ExperienceComponentPartial: ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
