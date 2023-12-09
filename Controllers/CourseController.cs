using basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace basic.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult List(){   
            return View("CourseList", Repository.Courses);
        }

        public IActionResult Detail(int id){
            if (Repository.GetById(id) == null)
            {
                return RedirectToAction("List");
            }

            var kurs = Repository.GetById(id);
            return View(kurs);
        }
    }
}