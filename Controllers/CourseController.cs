using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {

            var models = Repository.Applications.ToList();
            return View(models);
        }
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model)
        {
            if (Repository.Applications.Any(m => m.Email!.Equals(model.Email)))
            {
                ModelState.AddModelError("", "There is already applications");
            }

            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("FeedBack", model);
            }
            return View();
        }


    }
}
