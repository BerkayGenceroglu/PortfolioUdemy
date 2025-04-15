using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.Context;

namespace PortfolioUdemy.ViewComponentss
{
    public class _AboutComponentPartial: ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle= context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription= context.Abouts.Select(x => x.Description).FirstOrDefault();
            ViewBag.aboutDetail= context.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}
