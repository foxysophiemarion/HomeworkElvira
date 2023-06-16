Console.Clear();



int Prompt(string message)
{
	Console.Write(message);
	string value = Console.ReadLine();
	if ((int.TryParse(value, out int val)) == false)
	{
		Console.WriteLine("Ошибка! Введите число");
	}
	return val;
}

int c1 = Prompt("Введите значение b1 в уравнении 'y = k1 * x + b1' : ");
int a1 = Prompt("Введите значение k1 в уравнении 'y = k1 * x + b1' : ");
double b1 = -1;
int c2 = Prompt("Введите значение b2 в уравнении 'y = k1 * x + b1' : ");
int a2 = Prompt("Введите значение k2 в формуле 'y = k1 * x + b1' : ");
double b2 = -1;

double equationX = (((b1 * c2) - (b2 * c1)) / ((a1 * b2) - (a2 * b1)));
double equationY = (((c1 * a2) - (c2 * a1)) / ((a1 * b2) - (a2 * b1)));



Console.WriteLine($"Точка пересечения заданных прямых (x,y): ( {equationX} , {equationY} )");