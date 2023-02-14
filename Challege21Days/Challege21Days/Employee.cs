using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challege21Days
{
	public class Employee
	{
		private string name;
		private string surname;
		private short age;
		private int result;

		public int Result => result;

		public Employee(string name, string surname, short age)
		{
			this.name = name;
			this.surname = surname;
			this.age = age;

		}

		public void AddScore(int score)
		{
			if (score > 0)
			{
				result += score;
			}
			else
			{
				Console.WriteLine("Podana wartość nie jest wartością większą od 0.");
			}
		}

		public void LostScore(int score)
		{
			if (score > 0)
			{
				result -= score;
			}
			else
			{
				Console.WriteLine("Podana wartość jest wartością większą od 0.");
			}
		}

		public void Show()
		{
			Console.WriteLine("Imię: {name}", name);
			Console.WriteLine("Nazwisko: {surname}", surname);
			Console.WriteLine("Wiek: {age}", age);
			Console.WriteLine("punkty: {scores}\n", result);
		}
	}
}
