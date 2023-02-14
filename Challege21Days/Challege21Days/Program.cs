using Challege21Days;

List<Employee> employees = new List<Employee>();

Employee employee = new Employee("Adam", "####", 18);
employee.AddScore(5);
employee.AddScore(9);
employee.AddScore(4);
employee.AddScore(3);
employee.AddScore(1);
employees.Add(employee);

employee = new Employee("Zuzia", "####", 36);
employee.AddScore(6);
employee.AddScore(4);
employee.AddScore(5);
employee.AddScore(3);
employee.AddScore(4);
employees.Add(employee);

employee = new Employee("Robert", "####", 45);
employee.AddScore(1);
employee.AddScore(2);
employee.AddScore(3);
employee.AddScore(4);
employee.AddScore(5);
employees.Add(employee);


//There may several employee which gained the biggest score.
List<Employee> maxScoreEmployess = new List<Employee>();

foreach (var emp in employees)
{
	if (maxScoreEmployess.Count == 0)
	{
		maxScoreEmployess.Add(emp);
	}
	else if (maxScoreEmployess[0].Result == emp.Result)
	{
		maxScoreEmployess.Add(emp);
	}
	else if (maxScoreEmployess[0].Result < emp.Result)
	{
		maxScoreEmployess.Clear();
		maxScoreEmployess.Add(emp);
	}
}

Console.WriteLine("Pracownicy z nawyższą liczbą pkt:");
foreach (var emp in maxScoreEmployess)
{
	emp.Show();
}
