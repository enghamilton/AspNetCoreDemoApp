using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AspNetCoreDemoApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Index()
        {
            return View();
        }
        /*
        public string Index()
        {
            return "This is my default action...";
        }
        */
        
        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
