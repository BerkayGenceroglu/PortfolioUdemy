using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponentss.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
