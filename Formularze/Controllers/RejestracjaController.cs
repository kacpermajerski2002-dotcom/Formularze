using Formularze.Models;
using Microsoft.AspNetCore.Mvc;
using Formularze.Models;

namespace Formularze.Controllers
{
	public class RejestracjaController : Controller
	{
		[HttpGet]
		public IActionResult Form()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Form(Rejestracja model)
		{
			if (ModelState.IsValid)
			{
				ViewBag.Message = "Rejestracja zakończona pomyślnie";
				return View("Sukces");
			}

			return View(model);
		}
	}
}
