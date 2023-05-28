int number = Random();
Console.WriteLine("Сгенерированное число: " + number);
numberA(number);


void numberA(int number)
{
	int secondNumber = (number / 10) % 10;
	Console.WriteLine("Вторая цифра числа: " + secondNumber);
}

int Random()
{
	Random random = new Random();
	return random.Next(100, 1000);
}