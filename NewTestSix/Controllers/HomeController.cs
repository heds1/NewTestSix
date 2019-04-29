using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewTestSix.Models;

namespace NewTestSix.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Views/Home/Index.cshtml");
            //return View("Views/SubmitFormV2/Index.cshtml"); // doesn't work to change startup page
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // About view not populated with details yet. Seems like don't need to specify the full path.
        public IActionResult About()
        {
            return View();
        }

        // contact view not populated with details yet.
        public IActionResult Contact()
        {
            return View("Views/Home/Contact.cshtml");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
