// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Хотите я скажу является ли ваше число чётным?");
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA%2 == 0)
    Console.WriteLine("Ваше число чётное");
else
    Console.WriteLine("Ваше число нечётное");
