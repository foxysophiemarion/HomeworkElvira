Console.Write("Введите координаты первой точки через пробел: ");
string[] point1 = Console.ReadLine().Split(' ');
int x1 = int.Parse(point1[0]);
int y1 = int.Parse(point1[1]);
int z1 = int.Parse(point1[2]);

Console.Write("Введите координаты второй точки через пробел: ");
string[] point2 = Console.ReadLine().Split(' ');
int x2 = int.Parse(point2[0]);
int y2 = int.Parse(point2[1]);
int z2 = int.Parse(point2[2]);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между точками: " + distance);