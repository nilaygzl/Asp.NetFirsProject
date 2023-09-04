using Microsoft.AspNetCore.Mvc;
using ngMVC1.Models;

namespace ngMVC1.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
        public IActionResult Apply()  //get için çalışan metoddur.
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply(Candidate model)
        {
            if(Repository.Applications.Any(c=> c.Email.Equals(model.Email))) 
            {
                ModelState.AddModelError("", "There is already an application for you.");
            }
            if(ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Feedback", model);
            }
            return View();
        }

    }
    //public IActionResult Apply([FormForm] Candidate model) -->yukarıdaki method aslnda bu şekilde olmalı
    //{
    //    return View();
    //}
    //internal class FormFormAttribute : Attribute --> methodun kızmaması için gerekli
    //{
    //}
}
