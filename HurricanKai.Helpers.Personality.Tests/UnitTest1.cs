using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HurricanKai.Helpers.Person;

namespace HurricanKai.Helpers.Person.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void AddPersonKai()
		{
			Person expected = new Person { age = 13, birthdate = new DateTime(2003, 8, 20), name = "Kai" };
			Person result = PersonManager.AddPerson("Kai", new DateTime(2003, 8, 20));
			Assert.AreEqual(expected.age, result.age);
		}
	}
}
