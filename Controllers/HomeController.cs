using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basic.Models;

namespace basic.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(Repository.Courses);
    }

    public IActionResult Contact()
    {
        return View();
    }
}
