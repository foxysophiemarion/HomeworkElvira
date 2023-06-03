Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Таблица кубов чисел от 1 до " + number + ": ");
for (int i = 1; i <= number; i++)
{
	int cube = i * i * i;
	Console.WriteLine(i + "^3 = " + cube);
}