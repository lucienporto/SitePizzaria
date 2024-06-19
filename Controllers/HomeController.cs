using Microsoft.AspNetCore.Mvc;
using SitePizzaria.Models;
using System.Diagnostics;

namespace SitePizzaria.Controllers
{
	public class HomeController : Controller
	{
		

		public IActionResult Index()
		{
			return View();
		}

		
	}
}