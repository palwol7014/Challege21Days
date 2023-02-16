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
			grades.Add(grade);
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
