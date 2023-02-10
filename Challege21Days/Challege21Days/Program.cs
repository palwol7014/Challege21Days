using Challege21Days;

List<Employee> employees = new List<Employee>();

int[] grades = new int[5];
Random random = new Random();

employees.Add(new Employee("Adam", "####", 18, new int[] { 5, 9, 4, 3,1 } ));
employees.Add(new Employee("Zuzia", "####", 36, new int[] { 6, 4, 5, 3, 4 }));
employees.Add(new Employee("Robert", "####", 45, new int[] { 1, 2, 3, 4, 5 }));

//There may several employee which gained the biggest score.
List<Employee> maxScoreEmployess = new List<Employee>();

foreach(var emp in employees)
	if(maxScoreEmployess.Count == 0) maxScoreEmployess.Add(emp);
	else if (maxScoreEmployess[0].Scores == emp.Scores) maxScoreEmployess.Add(emp);
	else if (maxScoreEmployess[0].Scores < emp.Scores)
	{
		maxScoreEmployess.Clear();
		maxScoreEmployess.Add(emp);
	}

Console.WriteLine("Pracownicy z nawyższą liczbą pkt:");
foreach (var emp in maxScoreEmployess)
{
	emp.show();
	Console.WriteLine("");
}
