int[,] matrix = new int[4, 4];

for (int i = 0; i < 4; i++)
{
	for (int j = 0; j < 4; j++)
	{
		matrix[i, j] = Prompt($"Введите элемент ({i + 1}, {j + 1})");
	}
}

int minSum = int.MaxValue;
int minSumRow = -1;

for (int i = 0; i < 4; i++)
{
	int sum = 0;
	for (int j = 0; j < 4; j++)
	{
		sum += matrix[i, j];
	}
	if (sum < minSum)
	{
		minSum = sum;
		minSumRow = i + 1;
	}
}

Console.WriteLine($"Строка с наименьшей суммой: {minSumRow}");


int Prompt(string message)
{
	Console.Write($"{message}: ");
	string input = Console.ReadLine();
	return int.Parse(input);
}