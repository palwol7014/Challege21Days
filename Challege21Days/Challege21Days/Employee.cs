using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challege21Days
{
	public class Employee
	{
		private List<float> grades = new List<float>();
		public string Name{ get; private set; }
		public string Surname { get; private set; }

		public Employee(string name, string surname)
		{
			Name = name;
			Surname = surname;
		}

		public void AddGrade(float grade)
		{
			if (grade >= 0 && grade <= 100)
			{
				grades.Add(grade);
			}
			else
			{
				Console.WriteLine("Nieprawidłowa ocena. Ocena musi się mieścić w przedziale od 0 do 100.");
			}
		}

		public void AddGrade(string grade)
		{
			float fGrade;
			bool isParse = float.TryParse(grade, out fGrade);

			if (isParse && fGrade >= 0 && fGrade <= 100)
			{
				grades.Add(fGrade);
			}
			else
			{
				Console.WriteLine("Nieprawidłowa ocena. Ocena musi się mieścić w przedziale od 0 do 100.");
			}
		}

		public Statistics GetStatistics()
		{
			var statistics = new Statistics();
			foreach(var grade in grades)
			{
				statistics.Min = Math.Min(statistics.Min, grade);
				statistics.Max = Math.Max(statistics.Max, grade);
				statistics.Average += grade;
			}

			statistics.Average /= grades.Count;

			return statistics;
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"Imię: {Name}");
			sb.AppendLine($"Nazwisko: {Surname}");

			return sb.ToString();
		}
	}
}
