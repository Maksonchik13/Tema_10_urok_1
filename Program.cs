// ДЗ цифра
Console.Write("Введите радиус ");
double r = double.Parse(Console.ReadLine());
const double pi = Math.PI;
double S = pi * r * r;
double L = 2 * pi * r;
Console.WriteLine($"Площадь окружности = {S:f2}");
Console.WriteLine($"Длина окружности = {L:f2}");