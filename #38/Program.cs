int Prompt(string message)
{
	Console.Write(message);
	string value = Console.ReadLine();
	if ((int.TryParse(value, out int val)) == false)
	{
		Console.WriteLine("Это не число ");
	}
	return val;
}

double[] CreateRandomMassive(int val)
{
	// int [] array = new int [8];
	double[] array = new double[val];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(0, 100) / 100.00;
	}
	return array;
}

void PrintMassive(double[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write(array[i] + " ");
	}
	Console.WriteLine(" ");
}

double[] FindMiaxArray(double[] array)
{
	int size = array.Length;
	int current_index = 0;
	double fstMax = array[current_index];
	double scdMax = array[current_index];
	int fstMaxIndex = 0;
	int scdMaxIndex = 0;
	double fstMin = array[current_index];
	double scdMin = array[current_index];
	int fstMinIndex = 0;
	int scdMinIndex = 0;
	double[] result = new double[8];
	while (current_index < size)
	{
		if (array[current_index] > fstMax)
		{
			fstMax = array[current_index];
			fstMaxIndex = current_index;
		}
		if (array[current_index] < fstMin)
		{
			fstMin = array[current_index];
			fstMinIndex = current_index;
		}
		current_index++;
	}

	current_index = 0;
	if (fstMaxIndex == 0)
	{
		scdMax = array[1];
	}
	if (fstMinIndex == 0)
	{
		scdMin = array[1];
	}
	while (current_index < size)
	{
		if (current_index != fstMaxIndex)
		{
			if (array[current_index] > scdMax)
			{
				scdMax = array[current_index];
				scdMaxIndex = current_index;
			}
		}
		if (current_index != fstMinIndex)
		{
			if (array[current_index] < scdMin)
			{
				scdMin = array[current_index];
				scdMinIndex = current_index;
			}
		}
		current_index++;
	}

	result[0] = fstMax;
	result[1] = fstMin;
	result[2] = scdMax;
	result[3] = scdMin;
	result[4] = fstMaxIndex;
	result[5] = fstMinIndex;
	result[6] = scdMaxIndex;
	result[7] = scdMinIndex;
	return result;
}

Console.Clear();
int size = Prompt("Введите длинну массива: ");
double[] array = CreateRandomMassive(size);
PrintMassive(array);
double[] minmax = FindMiaxArray(array);
// PrintMassive(minmax); debug output
double fstsum = minmax[0] - minmax[1];
double scdsum = minmax[2] - minmax[3];

Console.WriteLine($"Разница между максимальным и минимальным равна: {fstsum}");
Console.WriteLine($"Разница между вторым максимальным и вторым минимальным равна: {scdsum}");