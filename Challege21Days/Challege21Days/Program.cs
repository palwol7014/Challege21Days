using Challege21Days;

Console.WriteLine("Witamy w programie noty do oceny pracowników.");

string name, surname;
		
Console.Write("Podaj imię: ");
name = Console.ReadLine();
Console.Write("Podaj nazwisko: ");
surname = Console.ReadLine();

Employee employee = new Employee(name, surname);

string input;
Console.WriteLine("Podaj ocenę od 0 do 100, lub ocenę w formie litery od a do j");
Console.WriteLine("A => 100 pkt, J => 10; pozostałe litery zmiana oceny o 10. \"W\" kończy wprowadzanie ocen.");
float grade;

do
{
	Console.WriteLine("Wpisz ocenę.");
	input = Console.ReadLine();
			
	if(float.TryParse(input, out grade))
	{
		employee.AddGrade(grade);
	}
	else
	{
		employee.AddGrade(input);
	}	
} while (input != "w" && input != "W");

Console.WriteLine("Informacje o pracowniku.");
Console.WriteLine(employee.ToString());
if(employee.Statistics is null)
{
	Console.WriteLine("Brak ocen.");
}
else
{
	Console.WriteLine(employee.Statistics.ToString());
	Console.WriteLine("\nW formacie literowym\n");
	Console.WriteLine(employee.Statistics.ToString(true));
}