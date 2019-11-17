using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemoApp.Controllers
{
	[Route("api/[controller]")]
        [Produces("application/json")]
	public class ValuesController : ControllerBase
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
		        var resultado = new
                            {
                                Nome = "user 01",
                                URL = "www.website.com.br"
                            };
                        return Json(resultado, JsonRequestBehavior.AllowGet);
		}
	}
}
