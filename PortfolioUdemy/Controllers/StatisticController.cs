using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.Context;

namespace PortfolioUdemy.Controllers
{
	public class StatisticController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		public IActionResult StatisticList()
		{
			ViewBag.v1 = context.Skills.Count();
			ViewBag.v2 = context.Messages.Count();
			ViewBag.v3 = context.Messages.Where(x => x.IsRead==false).Count();
			ViewBag.v4 = context.Messages.Where(x => x.IsRead==true).Count();
			ViewBag.v5 = context.Features.Count();
			ViewBag.v6 = context.Experiences.Count();
			ViewBag.v7 = context.Abouts.Count();
			ViewBag.v8 = context.Testimonials.Count();
			return View();
		}
	}
}
