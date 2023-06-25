Console.Write("Введите значение N: ");
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
{
	Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
}
PrintNumbers(n);


void PrintNumbers(int n)
{
	if (n == 0)
	{
		return;
	}
	Console.WriteLine(n);
	PrintNumbers(n - 1);
}