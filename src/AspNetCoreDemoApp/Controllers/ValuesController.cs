using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemoApp.Controllers
{
	[Route("api/[controller]")]
        [Produces("application/json")]
	public class ValuesController : Controller
	{
		// GET: api/values
		[HttpGet]
		public IEnumerable<string> Get()
		{
		    Console.WriteLine(Request.GetDisplayUrl());
		    Console.WriteLine(Request.GetEncodedUrl());

			return new[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public JsonResult Get(int id)
		{
		   return Json(new {pid="1", username="user 01", price="20.50", description="some text here"});
		}
                
                // GET: api/values/index
		[HttpGet]
                public IActionResult Index()
                {
                    ViewData["Message"] = "It works, done by Hamilton using C# .NET Core 3 MVC";
                    
                    return View("Views/Values/Index.cshtml");
                }

	}
}
