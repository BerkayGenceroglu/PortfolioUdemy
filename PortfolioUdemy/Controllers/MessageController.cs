using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.Context;

namespace PortfolioUdemy.Controllers
{
	public class MessageController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		public IActionResult Inbox()
		{
			var value = context.Messages.ToList();
			return View(value);
		}
		public IActionResult ChangeIsReadtoTrue(int id)
		{
			var value = context.Messages.Find(id);
			value.IsRead = true;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult ChangeIsReadtoFalse(int id)
		{
			var value = context.Messages.Find(id);
			value.IsRead = false;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult DeleteMessage(int id)
		{
			var value = context.Messages.Find(id);
			context.Messages.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult MessageDetail(int id) 
		{
            var value = context.Messages.Find(id);
            return View(value);
        }
	}
}
