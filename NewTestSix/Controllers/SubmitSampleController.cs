using Microsoft.AspNetCore.Mvc;
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

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}