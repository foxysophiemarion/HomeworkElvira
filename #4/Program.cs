Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

for (int i = 2; i <= n; i += 2)
{
	Console.Write(i + " ");
}