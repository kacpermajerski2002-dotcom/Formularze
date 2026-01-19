using Microsoft.AspNetCore.Mvc;
using Formularze.Models;

namespace Formularze.Controllers
{
	public class DaneController : Controller
	{
		[HttpGet]
		public IActionResult Form()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Form(Dane dane)
		{
			if (ModelState.IsValid)
			{
				return View("Wynik", dane);
			}
			else
			{
				return View();
			}
		}


		public IActionResult Wynik(Dane dane)
		{
			return View(dane);
		}
	}
}
