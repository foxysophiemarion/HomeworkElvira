Console.WriteLine("Введите значение m:");
int m;
while (!int.TryParse(Console.ReadLine(), out m) || m < 0)
{
	Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
}
Console.WriteLine("Введите значение n:");
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
{
	Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
}
Console.WriteLine($"A(m,n) = {Ackermann(m, n)}.");


int Ackermann(int m, int n)
{
	if (m == 0)
	{
		return n + 1;
	}
	else if (n == 0)
	{
		return Ackermann(m - 1, 1);
	}
	else
	{
		return Ackermann(m - 1, Ackermann(m, n - 1));
	}
}