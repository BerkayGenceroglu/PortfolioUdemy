using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.Context;

namespace PortfolioUdemy.ViewComponentss.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		PortfolioContext context = new PortfolioContext();	
		public IViewComponentResult Invoke()
		{
			ViewBag.todoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
			var values = context.ToDoLists.Where(x => x.Status==false).ToList();
			return View(values);
		}
	}
}
