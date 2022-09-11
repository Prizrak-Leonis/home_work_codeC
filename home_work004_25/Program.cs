// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Возведение числа в натуральную степень.");
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите в какую степень нужно возвести введёное выше число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numA + "^" + numB + " = " + Math.Pow(numA, numB));
