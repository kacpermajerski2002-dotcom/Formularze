using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Formularze.Models
{
	public class Rejestracja
	{
		[Required(ErrorMessage = "Podaj imię")]
		[MinLength(2, ErrorMessage = "Imię musi mieć min. 2 znaki")]
		public string Imie { get; set; }

		[Required(ErrorMessage = "Podaj nazwisko")]
		[MinLength(2, ErrorMessage = "Nazwisko musi mieć min. 2 znaki")]
		public string Nazwisko { get; set; }

		[Required(ErrorMessage = "Podaj email")]
		[EmailAddress(ErrorMessage = "Niepoprawny adres email")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Podaj hasło")]
		[DataType(DataType.Password)]
		[RegularExpression(
			@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$",
			ErrorMessage = "Hasło min. 8 znaków, duża litera, mała litera i cyfra")]
		public string Haslo { get; set; }

		[Required(ErrorMessage = "Potwierdź hasło")]
		[DataType(DataType.Password)]
		[Compare("Haslo", ErrorMessage = "Hasła muszą być takie same")]
		public string PotwierdzHaslo { get; set; }

		[Phone(ErrorMessage = "Niepoprawny numer telefonu")]
		public string Telefon { get; set; }

		[Range(11, 80, ErrorMessage = "Wiek od 11 do 80 lat")]
		public int Wiek { get; set; }

		[Required]
		public Miasta Miasto { get; set; }

		public enum Miasta
		{
			Warszawa = 1,
			Krakow = 2,
			Lodz = 3,
			Wroclaw = 4,
			Poznan = 5
		}
	}
}
