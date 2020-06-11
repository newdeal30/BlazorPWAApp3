using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp3.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : ControllerBase {
		
		
		[HttpGet]
		public string Get() {
			return $"Hello - {DateTime.Now.ToLongTimeString()} {DateTime.Now.Millisecond}msec ";
		}
	}
}
