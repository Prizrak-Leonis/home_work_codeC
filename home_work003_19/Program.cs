// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Является ли число палиндромом?");
string inputNumberAAAAA()
{
    Console.Write("Введите пятизначное число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    while (a < 10000 || a > 99999)
    {
        Console.Write("Пятизначное число состоит из 5 цифр, пожалуйста, введите пятизначное число: ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return Convert.ToString(a);
}
string numA = inputNumberAAAAA();
if (numA[0] == numA[4] && numA[1] == numA[3])
    Console.WriteLine("Да, является");
else
    Console.WriteLine("Нет");
