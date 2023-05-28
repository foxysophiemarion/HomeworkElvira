int random = new Random().Next(100, 1000);
Console.WriteLine("Сгенерированное число: " + random);

int number = (random / 10) % 10;
Console.WriteLine("Вторая цифра трехзначного числа: " + number);