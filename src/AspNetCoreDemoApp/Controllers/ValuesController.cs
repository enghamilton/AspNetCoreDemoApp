using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

//
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreDemoApp.Model;
//

namespace AspNetCoreDemoApp.Controllers
{
	[Route("api/[controller]")]
	public class ValuesController : Controller
	{
                private readonly ProductContext _context;
                
                public ValuesController(ProductContext context){
                        _context = context;
                }
                
                [HttpGet("/products")]
                public async Task<ActionResult> Index(){
                   return View(await _context.Products.toListAsync());
                }
                
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
                        /*
                        List<Object> resultado = new List<object>();
                        resultado.Add(new
                            {
                                Nome = "user 01",
                                URL = "www.website01.com.br"
                            });
                                resultado.Add(new
                            {
                                Nome = "user 02",
                                URL = "www.website02.com.br"
                            });
                                resultado.Add(new
                            {
                                Nome = "user 03",
                                URL = "www.website03.com.br"
                            });
                    return Json(resultado, JsonRequestBehavior.AllowGet);
                    */
		   return Json(new {id="1", username="user 01", price="20.50", description="some text here hamilton"});
		}
                
	}
}
