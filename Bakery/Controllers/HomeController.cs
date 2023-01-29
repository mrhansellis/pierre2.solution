using Bakery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Controllers
{
	public class HomeController : Controller
	{
		private readonly BakeryContext _db;

		public HomeController(BakeryContext db)
		{
			_db = db;
		}

		[HttpGet("/")]
		public ActionResult Index()
		{
			Flavor[] flv = _db.Flavors.ToArray();
			Treat[] trt = _db.Treats.ToArray();
			Dictionary<string,object[]> model = new Dictionary<string, object[]>();
			model.Add("flavors", flv);
			model.Add("treats", trt);
			return View(model);
		}

		public ActionResult Privacy()
		{
			return View();
		}
	}
}