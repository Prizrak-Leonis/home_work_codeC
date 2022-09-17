// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Задайте две прямые представленные уравнениями формата y=kx+b");
Console.Write("Введите чему равно k для первого уравнения: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чему равно b для первого уравнения: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чему равно k для второго уравнения: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чему равно b для второго уравнения: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.Write($"Прямые у={k1}x");
if(b1>0) Console.Write("+");
Console.Write($"{b1} и у={k2}x");
if(b2>0) Console.Write("+");
Console.WriteLine($"{b2} пересекаются в точке ({x}; {y})");
