Console.Clear();

int Prompt(string msg)
{
	Console.Write(msg);
	string value = Console.ReadLine();
	int val = 0;
	while ((int.TryParse(value, out val)) != true)
	{
		Console.Write("Неверный ввод. Повторите: ");
		value = Console.ReadLine();
	}
	Console.Clear();
	return val;
}

void PrintArray(double[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write(array[i] + "_");
	}
	Console.Write(array[array.Length - 1] + " ");
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write($" {matrix[i, j]}");
		}
		Console.WriteLine();
	}
}

int[,] CreateMRandoMatrix(int rows, int columns, int from, int to)
{
	int[,] matrix = new int[rows, columns];
	to++;
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = new Random().Next(from, to);
		}
	}
	return matrix;
}

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начальное значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");

int[,] matr = CreateMRandoMatrix(row, col, from, to);
double[] summCol = new double[matr.GetLength(1)];

PrintMatrix(matr);
Console.WriteLine();


for (int j = 0; j < matr.GetLength(1); j++)
{
	int summ = 0;
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		summ = summ + matr[i, j];

	}

	summCol[j] = summ;
	Console.Write($"{summCol} ");
	Console.WriteLine();
}

PrintArray(summCol);
Console.WriteLine();
for (int i = 0; i < summCol.Length; i++)
{
	Console.WriteLine($"Среднее арифметическое {i + 1} столбца равно {summCol[i] / matr.GetLength(0)}");
}