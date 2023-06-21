int[,] matrix1, matrix2, resultMatrix;

// Получаем первую матрицу
Console.WriteLine("Введите размерность первой матрицы (MxN):");
int m1 = PromptInt("M");
int n1 = PromptInt("N");
matrix1 = GetMatrix("первой", m1, n1);

// Получаем вторую матрицу
Console.WriteLine("Введите размерность второй матрицы (NxP):");
int n2 = PromptInt("N");
int p2 = PromptInt("P");
matrix2 = GetMatrix("второй", n2, p2);

// Проверяем, можно ли перемножить матрицы
if (n1 != n2)
{
	Console.WriteLine("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
	Console.ReadKey();
	return;
}

// Создаем результирующую матрицу
resultMatrix = new int[m1, p2];

// Вычисляем произведение матриц
for (int i = 0; i < m1; i++)
{
	for (int j = 0; j < p2; j++)
	{
		int sum = 0;
		for (int k = 0; k < n1; k++)
		{
			sum += matrix1[i, k] * matrix2[k, j];
		}
		resultMatrix[i, j] = sum;
	}
}

// Выводим результат
Console.WriteLine("Результат умножения матриц:");
PrintMatrix(resultMatrix);

Console.ReadKey();


// Метод для получения матрицы от пользователя
static int[,] GetMatrix(string matrixName, int rows, int columns)
{
	int[,] matrix = new int[rows, columns];
	Console.WriteLine($"Введите элементы {matrixName} матрицы ({rows}x{columns}):");
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			matrix[i, j] = PromptInt($"[ {i + 1} , {j + 1} ]");
		}
	}
	return matrix;
}

// Метод для вывода матрицы в консоль
static void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write(matrix[i, j] + " ");
		}
		Console.WriteLine();
	}
}

// Метод для получения введенного пользователем целого числа
static int PromptInt(string prompt)
{
	while (true)
	{
		Console.Write($"Введите целое число {prompt}: ");
		if (int.TryParse(Console.ReadLine(), out int num))
		{
			return num;
		}
		Console.WriteLine("Неверный ввод! Попробуйте снова.");
	}
}