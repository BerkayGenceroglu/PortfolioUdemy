using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.Context;

namespace PortfolioUdemy.ViewComponentss
{
    public class _SkillComponentPartial: ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
