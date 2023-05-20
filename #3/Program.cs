Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
	Console.WriteLine("Число " + num + " четное");
}
else
{
	Console.WriteLine("Число " + num + " нечетное");
}