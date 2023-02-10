using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challege21Days
{
	internal class Employee
	{
		private string name;
		private string surname;
		private short age;
		private int scores;

		public int Scores
		{
			get
			{
				return scores;
			}
		}

		public void show()
		{

			Console.WriteLine("Imię: {0}", name);
			Console.WriteLine("Nazwisko: {0}", surname);
			Console.WriteLine("Wiek: {0}", age);
			Console.WriteLine("punkty: {0}", scores);
		}
		public Employee(string name, string surname, short age, int[] tabScores)
		{
			this.name = name;
			this.surname = surname;
			this.age = age;

			foreach (var item in tabScores)
				scores += item;
		}
	}
}
