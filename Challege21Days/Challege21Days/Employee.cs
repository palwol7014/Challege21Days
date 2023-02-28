using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challege21Days
{
	public class Employee : Person
	{
		private List<float> grades = new List<float>();
		private bool isChange = false;
		private Statistics? statistics;
		public Statistics? Statistics
		{
			get
			{
				if(isChange)
				{
					GetStatistics();
				}

				return statistics;
			}
		}

		public Employee(string name, string surname) : base(name, surname)
		{
		}

		public void AddGrade(float grade)
		{
			if (grade >= 0 && grade <= 100)
			{
				grades.Add(grade);
				isChange = true;
			}
			else
			{
				throw new Exception("Nieprawidłowa ocena. Ocena musi się mieścić w przedziale od 0 do 100.");
			}
		}

		public void AddGrade(string grade)
		{
			grade = grade.ToLower();

			if (grade[0] >= 'a' && grade[0] <= 'j')
			{
				grades.Add(('j' - grade[0] + 1) * 10);
				isChange = true;
			}
			else
			{
				throw new Exception("Nieprawidłowa litera. Tylko są akceptowalne litery od \"a\" do \"j\"");
			}
		}

		private void GetStatistics()
		{
			statistics ??= new Statistics();

			foreach (var grade in grades)
			{
				statistics.Min = Math.Min(statistics.Min, grade);
				statistics.Max = Math.Max(statistics.Max, grade);
				statistics.Average += grade;
			}

			statistics.Average /= grades.Count;
			isChange = false;
		}
		/*
		 * The method converts the grade to a letter. A is 100 or more and J is 10 or less. The other letters change every 10 points.
		 */
		public static char ConvertGradeToLetter(float grade)
		{
			int gradeInInt = (int)(grade / 10);

			if (gradeInInt > 9)
			{
				return 'A';
			}
			else
			{
				return (char)('J' - gradeInInt);
			}
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"Imię: {Name}");
			sb.AppendLine($"Nazwisko: {Surname}\n");

			return sb.ToString();
		}
	}
}
