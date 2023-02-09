int[] digits = new int[10];
int num = 542641100;

Console.WriteLine("Dla liczby {0}\n", num);

do
{
	digits[num % 10]++;
	num /= 10;
}while(num > 0);

for(int i = 0; i < digits.Length; i++)
	Console.WriteLine("{0} => {1}", i , digits[i]);