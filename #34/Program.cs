Console.Clear();

int Prompt(string message)
{
	Console.Write(message);
	string value = Console.ReadLine();
	if ((int.TryParse(value, out int val)) == false)
	{
		Console.WriteLine("Не является числом");
	}
	return val;
}

int[] CreateRandomMassive(int val)
{
	// int [] array = new int [8];
	int[] array = new int[val];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(100, 1000);
	}
	return array;
}

void PrintMassive(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write(array[i] + " ");
	}
}

void PrintEven(int[] array)
{
	int count2 = 0;
	int count1 = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0)
		{
			count2++;
		}
		else
		{
			count1++;
		}
	}
	Console.WriteLine($"Количество четных чисел в массиве равно: {count2} ");
	Console.WriteLine($"Количество нечетных чисел в массиве равно: {count1} ");
}

int value = Prompt("Введите длинну массива: ");

int[] arr = CreateRandomMassive(value);
PrintMassive(arr);
Console.WriteLine(" ");
PrintEven(arr);