string name = "Ewa";
char gender = 'k';
short age = 33;

if (gender == 'k' && age < 30)
	Console.WriteLine("Kobieta poniżej 30 lat.");

else if (name == "Ewa" && age == 33)
	Console.WriteLine("Ewa lat {0}", age);

else if (gender == 'm' && age < 18)
	Console.WriteLine("Niepełnoletni mężczyzna.");

else if (gender == 'k' && age >= 60)
	Console.WriteLine("Kobieta w wieku emerytalnym.");

else if (gender == 'm' && age >= 65)
	Console.WriteLine("Meżczyzna w wieku emerytalnym.");