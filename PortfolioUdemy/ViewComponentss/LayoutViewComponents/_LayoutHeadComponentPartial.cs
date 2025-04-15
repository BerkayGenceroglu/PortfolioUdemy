using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponentss.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
