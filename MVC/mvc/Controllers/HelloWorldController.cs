using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace mvc.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {

            ViewData["message"] = nome;
            ViewData["numTimes"] = numTimes;

            return View();
        }
    }
}
