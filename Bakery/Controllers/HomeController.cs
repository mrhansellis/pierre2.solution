﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers;

public class HomeController : Controller
{

	public IActionResult Index()
	{
		return View();
	}
}
