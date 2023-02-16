using Challege21Days;

var employee = new Employee("Paweł", "Jakiś tam");
employee.AddGrade(3);
employee.AddGrade(4);
employee.AddGrade(6);

Console.WriteLine(employee.ToString());
Console.WriteLine(employee.GetStatistics().ToString());