Console.WriteLine("Введите числовое значение дня недели: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7)
{
	Console.WriteLine("Выходной день!");
}
if (day >= 8)
{
	Console.WriteLine("Нет такого дня недели!");
}
else
{
	Console.WriteLine("Не выходной день.");
}
