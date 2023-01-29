Console.WriteLine("Введите коэффициенты для уравнений прямых: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Координаты пересечения двух прямых - ({x}, {y})");
