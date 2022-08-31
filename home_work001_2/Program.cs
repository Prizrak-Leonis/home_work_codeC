// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Хотите я скажу какое из двух чисел больше, а какое меньше?");
Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB)
    Console.WriteLine(numA + " > " + numB);
else if (numA < numB)
    Console.WriteLine(numA + " < " + numB);
else
    Console.WriteLine(numA + " = " + numB);
