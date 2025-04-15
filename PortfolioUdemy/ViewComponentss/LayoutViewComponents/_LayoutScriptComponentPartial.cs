using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponentss.LayoutViewComponents
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
