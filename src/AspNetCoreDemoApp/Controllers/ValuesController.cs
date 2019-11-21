using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemoApp.Controllers
{
	[Route("api/[controller]")]
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
                        List<Object> resultado = new List<object>();
                        resultado.Add(new
                            {
                                Nome = "user 01",
                                URL = "www.linhadecodigo.com.br"
                            });
                                resultado.Add(new
                            {
                                Nome = "user 02",
                                URL = "www.devmedia.com.br"
                            });
                                resultado.Add(new
                            {
                                Nome = "user 03",
                                URL = "www.mrbool.com.br"
                            });
                    return Json(resultado, JsonRequestBehavior.AllowGet);
		   //return Json(new {pid="1", username="user 01", price="20.50", description="some text here"});
		}
                
	}
}
