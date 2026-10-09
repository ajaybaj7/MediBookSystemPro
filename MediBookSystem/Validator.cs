using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MediBookSystem
{
	/// <summary>
	/// Shared input validation for dates, times, numbers, names and phone numbers.
	/// </summary>
	public static class Validator
	{
		public const string DateFormat = "yyyy-MM-dd";
		public const string TimeFormat = "hh:mm tt";   // e.g. 10:30 AM

		static readonly string[] DateFormats = { "yyyy-M-d", "yyyy/M/d", "d/M/yyyy", "d-M-yyyy" };
		static readonly string[] TimeFormats = { "h:mm tt", "hh:mm tt", "h:mmtt", "h tt", "H:mm", "HH:mm" };

		// ── Parsing ──

		public static bool TryDate(string text, out DateTime date)
		{
			return DateTime.TryParseExact((text ?? "").Trim(), DateFormats,
				CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
		}

		public static bool TryTime(string text, out DateTime time)
		{
			return DateTime.TryParseExact((text ?? "").Trim(), TimeFormats,
				CultureInfo.InvariantCulture, DateTimeStyles.None, out time);
		}

		/// <summary>Whole number from 1 to 120.</summary>
		public static bool TryAge(string text, out int age)
		{
			age = 0;
			text = (text ?? "").Trim();
			if (!Regex.IsMatch(text, @"^\d{1,3}$")) return false;
			age = int.Parse(text);
			return age >= 1 && age <= 120;
		}

		/// <summary>Positive amount, at most 2 decimal places, up to 10,000,000.</summary>
		public static bool TryAmount(string text, out decimal amount)
		{
			amount = 0;
			text = (text ?? "").Trim();
			if (!Regex.IsMatch(text, @"^\d{1,8}(\.\d{1,2})?$")) return false;
			amount = decimal.Parse(text, CultureInfo.InvariantCulture);
			return amount > 0 && amount <= 10000000m;
		}

		/// <summary>Nepali mobile number: 10 digits starting 96/97/98, optional +977.</summary>
		public static bool IsPhone(string text)
		{
			text = (text ?? "").Trim();
			return Regex.IsMatch(text, @"^(\+?977[- ]?)?9[678]\d{8}$");
		}

		/// <summary>2–50 chars, letters only, must look like a real first + last name.</summary>
		public static bool IsName(string text)
		{
			text = (text ?? "").Trim();

			// allowed characters and length
			if (!Regex.IsMatch(text, @"^[A-Za-z][A-Za-z .'\-]{1,49}$")) return false;

			// reject keyboard mashing: "asdasd", "aaaa", "SEFSAFAF"
			if (IsGarbage(text)) return false;

			// must contain at least two letter groups (first + last name)
			if (!Regex.IsMatch(text, @"^[A-Za-z]+([ .'\-]+[A-Za-z]+)+$")) return false;

			return true;
		}

		/// <summary>2–50 chars, letters with spaces, dots, hyphens or apostrophes. Single word OK.</summary>
		public static bool IsSpecialization(string text)
		{
			text = (text ?? "").Trim();

			// allowed characters and length
			if (!Regex.IsMatch(text, @"^[A-Za-z][A-Za-z .'\-]{1,49}$")) return false;

			// reject keyboard mashing: "asdasd", "aaaa", "SEFSAFAF"
			if (IsGarbage(text)) return false;

			return true;
		}

		/// <summary>
		/// Optional symptoms text: empty is OK, otherwise 3–300 chars of
		/// letters, digits, spaces and , . - ' / ( )
		/// </summary>
		public static bool IsSymptoms(string text)
		{
			text = (text ?? "").Trim();
			if (text.Length == 0) return true;   // optional

			if (text.Length < 3 || text.Length > 300) return false;
			return Regex.IsMatch(text, @"^[A-Za-z0-9 ,.'()/\-]+$");
		}

		/// <summary>True if text looks like keyboard mashing ("asdasd", "aaaa", "abcabc").</summary>
		static bool IsGarbage(string text)
		{
			// 3+ identical characters in a row: "aaaa", "SEEES"
			if (Regex.IsMatch(text, @"(\w)\1{2,}")) return true;

			// any 2+ character sequence repeated: "asdasd", "AFAF"
			if (Regex.IsMatch(text, @"(\w{2,})\1")) return true;

			return false;
		}

		// ── Showing errors ──

		/// <summary>Shows a warning, focuses the bad control and returns false.</summary>
		public static bool Fail(Control control, string message)
		{
			MessageBox.Show(message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			if (control != null)
			{
				control.Focus();
				TextBox tb = control as TextBox;
				if (tb != null) tb.SelectAll();
			}
			return false;
		}

		// ── Typing filters (attach with: textBox.KeyPress += Validator.DigitsOnly;) ──

		public static void DigitsOnly(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar));
		}

		public static void PhoneChars(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == '+');
		}

		public static void DecimalChars(object sender, KeyPressEventArgs e)
		{
			TextBox tb = sender as TextBox;
			bool dotOk = e.KeyChar == '.' && tb != null && !tb.Text.Contains(".");
			e.Handled = !(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || dotOk);
		}

		public static void NameChars(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) ||
				e.KeyChar == ' ' || e.KeyChar == '.' || e.KeyChar == '\'' || e.KeyChar == '-');
		}

		/// <summary>Symptoms: letters, digits, spaces and , . - ' / ( )</summary>
		public static void SymptomsChars(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) ||
				e.KeyChar == ' ' || e.KeyChar == ',' || e.KeyChar == '.' ||
				e.KeyChar == '-' || e.KeyChar == '\'' || e.KeyChar == '/' ||
				e.KeyChar == '(' || e.KeyChar == ')');
		}

		public static void DateChars(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) ||
				e.KeyChar == '-' || e.KeyChar == '/');
		}

		public static void TimeChars(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == ':' ||
				e.KeyChar == ' ' || "aApPmM".IndexOf(e.KeyChar) >= 0);
		}
	}
}