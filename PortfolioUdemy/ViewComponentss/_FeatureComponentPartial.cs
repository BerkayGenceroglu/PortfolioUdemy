using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.Context;

namespace PortfolioUdemy.ViewComponentss
{
    public class _FeatureComponentPartial:ViewComponent
    {
        PortfolioContext PortfolioContext= new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = PortfolioContext.Features.ToList();
            return View(values);
        }
    }
}
