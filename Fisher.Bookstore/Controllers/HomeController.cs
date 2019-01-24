using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class HomeController : Controller
    {  
         public IActionResult Index()
        {
            return Content("Hello World");
        }
    }
    public class AboutController : Controller
    {  
         public IActionResult Index()
        {
            return Content("This is index");
        }
        public IActionResult History()
        {
            return Content("This is history");
        }
        public IActionResult Location()
        {
            return Content("This is location");
        }
    }
}