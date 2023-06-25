Console.WriteLine("Введите значение M:");
int m;
while (!int.TryParse(Console.ReadLine()!, out m) || m < 1)
{
	Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
}
Console.WriteLine("Введите значение N:");
int n;
while (!int.TryParse(Console.ReadLine()!, out n) || n < m)
{
	Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
}
int sum = 0;
for (int i = m; i <= n; i++)
{
	sum += i;
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {sum}.");