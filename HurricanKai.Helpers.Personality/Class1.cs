using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurricanKai.Helpers.Person
{
	public struct Person
	{
		public string name;
		public int age;
		public DateTime birthdate;

		public int getage()
		{
			// Save today's date.
			var today = DateTime.Today;
			// Calculate the age.
			age = today.Year - birthdate.Year;
			// Go back to the year the person was born in case of a leap year
			if (birthdate > today.AddYears(-age)) age--;
			return age;
		}

	}

	public class PersonManager
    {
		public static Person AddPerson(string name, DateTime birthdate)
		{
			Person Kai;
			Kai.name = name;
			Kai.birthdate = birthdate;
			Kai.age = 0;
			Kai.age = Kai.getage();
			return Kai;
		}
    }
}
