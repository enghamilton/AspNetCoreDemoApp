using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemoApp.Controllers
{
	[Route("api/[controller]/[action]")]
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
		   return Json(new {pid="1", username="user 01 hamilton", price="20.50", description="some text here"});
		}
                
                // GET api/values/index
		[HttpGet]
                public IActionResult Index()
                {
                   return View();
                }

	}
}
