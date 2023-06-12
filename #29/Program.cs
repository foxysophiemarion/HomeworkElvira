int Prompt(string message)
{
	System.Console.Write(message);
	string ReadInput = System.Console.ReadLine();
	int result = int.Parse(ReadInput);
	return result;
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
	int[] array = new int[Length];
	Random random = new Random();
	for (int i = 0; i < Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}
	return array;
}

void Print(int[] array)
{
	System.Console.Write("[");
	for (int i = 0; i < array.Length - 1; i++)
	{
		System.Console.Write($"{array[i]}, ");
	}
	System.Console.Write($"{array[array.Length - 1]}");
	System.Console.WriteLine("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
Print(array);
