using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers {
    public class HelloWorldController : Controller {
        /* Note about controllers
            The default URL Routing logic in ASP.NET MVC applications uses the format
                /[Controller]/[ActionName]/[Parameters]
        */


        //
        // GET: /HelloWorld/
        public IActionResult Index() {
            return View();
        }
        //
        // GET: /HelloWorld/Welcome
        public string Welcome(string name, int numTimes = 1) {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}