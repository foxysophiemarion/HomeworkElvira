// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
	// Console.Clear();
	return val;
}

string Prompt2(string msg)
{
	Console.Write(msg);
	string value = Console.ReadLine();
	return value;
}

void PrintMatrix(int[,] matrix)
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

int[,] CreateMRandoMatrix(int rows, int columns, int from, int to)
{
	int[,] matrix = new int[rows, columns];
	to++;
	for (int row = 0; row < matrix.GetLength(0); row++)
	{
		for (int column = 0; column < matrix.GetLength(1); column++)
		{
			matrix[row, column] = new Random().Next(from, to);
		}
	}
	return matrix;
}

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начально значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");
int[,] matr = CreateMRandoMatrix(row, col, from, to);
PrintMatrix(matr);

int temp1 = row;
int temp2 = col;
string temp = string.Empty;
int i = 1;
while (i > 0)
{
	row = Prompt("Введите строку элемента: ");
	col = Prompt("Введите столбец элемента: ");
	int a = row - 1;
	int b = col - 1;
	if (row <= 0 || row > matr.GetLength(0) || col <= 0 || col > matr.GetLength(1))
	{
		Console.WriteLine("Такого элемента нет в массиве");
	}
	else
	{
		Console.WriteLine($"Искомый элемент в массиве равен: {matr[a, b]}");
	}
	temp = Prompt2("Вы хотите еще поискать элементы? (Y-да, N-нет): ");
	if (temp.ToLower() == "y")
	{
		i++;
	}
	else
	{
		i = -1;
	}
}