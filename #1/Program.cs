Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int max = a > b ? a : b;

Console.WriteLine("Большее число: " + max);
Console.WriteLine("Меньшее число: " + (a + b - max));
