using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challege21Days
{
	public class Statistics
	{
		public float Max { get; set; }
		public float Min { get; set; }
		public float Average { get; set; }

		public Statistics()
		{
			Max = float.MinValue;
			Min = float.MaxValue;
		}

		public string ToString(bool formatLetter = false)
		{
			var sb = new StringBuilder();
			char max, min, average;

			if (formatLetter)
			{
				max = Employee.ConvertGradeToLetter(Max);
				min = Employee.ConvertGradeToLetter(Min);
				average = Employee.ConvertGradeToLetter(Average);

				sb.AppendLine($"Najwyższa ocena: {max}");
				sb.AppendLine($"Najniższa ocena: {min}");
				sb.AppendLine($"Średnia ocena: {average}");
			}
			else
			{
				sb.AppendLine($"Najwyższa ocena: {Max:N2}");
				sb.AppendLine($"Najniższa ocena: {Min:N2}");
				sb.AppendLine($"Średnia ocena: {Average:N2}"); 
			}

			return sb.ToString();
		}
	}
}
