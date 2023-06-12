int Prompt(string message)
{
	System.Console.Write(message);
	string readInput = System.Console.ReadLine();
	int result = int.Parse(readInput);
	return result;
}

int Degree(int digitA, int digitB)
{
	int number = 1;
	for (int i = 0; i < digitB; i++)
	{
		number *= digitA;
	}
	return number;
}

bool numberB(int digitB)
{
	if (digitB < 0)
	{
		System.Console.WriteLine("Число B не должно быть меньше нуля");
		return false;
	}
	return true;
}

int digitA = Promt("Введите число A: ");
int digitB = Promt("Введите число B: ");

if (numberB(digitB))
{
	System.Console.WriteLine($"Число {digitA} в степени {digitB} равно {Degree(digitA, digitB)}");
}