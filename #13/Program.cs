Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int thirdNumber(int arg)
{
	int arg1 = arg / 100;
	if (arg1 >= 1 & arg1 < 10)
	{
		int arg0 = arg % 10;
		Console.WriteLine("Третья цифра заданного числа: " + arg0);
	}
	else
	{
		Console.WriteLine("Третьей цифры нет");
	}
	return arg1;
}

int result = thirdNumber(number);