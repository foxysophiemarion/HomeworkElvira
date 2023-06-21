Console.Clear();

int Prompt(string msg)
{
	Console.Write(msg);
	string value = Console.ReadLine();
	if ((int.TryParse(value, out int val)) == false)
	{
		Console.WriteLine("Это не число ");
	}
	return val;
}

void PrintMatrix(double[,] matrix)
{
	for (int row = 0; row < matrix.GetLength(0); row++)
	{
		for (int column = 0; column < matrix.GetLength(1); column++)
		{
			Console.Write($" {matrix[row, column]}");
		}
		Console.WriteLine();
	}
}

double[,] CreateMRandoMatrix(int rows, int columns, int from, int to)
{
	double[,] matrix = new double[rows, columns];
	to++;
	Random rnd = new Random();
	for (int row = 0; row < matrix.GetLength(0); row++)
	{
		for (int column = 0; column < matrix.GetLength(1); column++)
		{
			matrix[row, column] = Math.Round(-42.132 + rnd.NextDouble() * (7.003 + 42.132), 1);

		}
	}
	return matrix;
}

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начально значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");
double[,] matr = CreateMRandoMatrix(row, col, from, to);
PrintMatrix(matr);