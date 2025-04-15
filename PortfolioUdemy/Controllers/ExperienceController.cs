using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.Context;
using PortfolioUdemy.DAL.Entities;

namespace PortfolioUdemy.Controllers
{
    public class ExperienceController : Controller
    {
        PortfolioContext context = new PortfolioContext();
		public IActionResult ExperienceList()
        {
			var experiences = context.Experiences.ToList();
			return View(experiences);
        }

        [HttpGet]
        public IActionResult InsertExperience()
        {
            return View();
		}
		[HttpPost]
		public IActionResult InsertExperience(Experience e)
		{
			context.Experiences.Add(e);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");	
		}
		public IActionResult DeleteExperience(int id)
		{
			var value = context.Experiences.Find(id);
			context.Experiences.Remove(value);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
		[HttpGet]
		public IActionResult UpdateExperience(int id)
		{
			var value = context.Experiences.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateExperience(Experience exp)
		{
			context.Experiences.Update(exp);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
