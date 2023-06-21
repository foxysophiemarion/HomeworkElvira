int rows = 3;
int cols = 4;

int[,] matrix = new int[rows, cols];
Console.WriteLine("Введите элементы массива:");

for (int i = 0; i < rows; i++)
{
	for (int j = 0; j < cols; j++)
	{
		Console.Write("[{0},{1}]: ", i, j);
		matrix[i, j] = int.Parse(Console.ReadLine());
	}
}

// Сортировка элементов каждой строки по убыванию
for (int i = 0; i < rows; i++)
{
	for (int j = 0; j < cols - 1; j++)
	{
		for (int k = j + 1; k < cols; k++)
		{
			if (matrix[i, j] < matrix[i, k])
			{
				int temp = matrix[i, j];
				matrix[i, j] = matrix[i, k];
				matrix[i, k] = temp;
			}
		}
	}
}

Console.WriteLine("\nОтсортированный массив:");

for (int i = 0; i < rows; i++)
{
	for (int j = 0; j < cols; j++)
	{
		Console.Write("{0} ", matrix[i, j]);
	}
	Console.WriteLine();
}