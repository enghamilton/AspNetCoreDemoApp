using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemoApp.Controllers
{
	[Route("api/[controller]")]
  public class DemoController : Controller
{
   [Route("")]
   [Route("Demo")]
   [Route("Demo/Index")]
   public IActionResult Index()
   {
      return View("Views/Demo/index.cshtml");
   }
   [Route("Demo/About")]
   public IActionResult About()
   {
      return View();
   }
   [Route("Demo/Contact")]
   public IActionResult Contact()
   {
      return View();
   }
}
}
