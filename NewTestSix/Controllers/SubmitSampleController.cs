using Microsoft.AspNetCore.Mvc;
using NewTestSix.Models;
using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace NewTestSix.Controllers
{
    public class SubmitSampleController : Controller
    {
        // 
        // GET: /HelloWorld/
        // Calls the controller's View method. Uses a View template to generate a HTML response. Controller methods (aka action methods) generally return an IActionResult, not a type like string.

        public IActionResult Index()
        {
            return View("Views/SubmitSample/Index.cshtml");
        }

        [HttpPost]
        public ActionResult Index(RequestedAnalyses u)
        {
            ViewBag.AcidStables = u.AcidStables;
            ViewBag.Sulfurs = u.Sulfurs;
            ViewBag.Trp = u.Trp;
            ViewBag.FAAs = u.FAAs;
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }



    }
}