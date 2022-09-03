// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int inputNumberAAA()
{
    Console.Write("Введите трёхзначное число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    while (a < 100 || a > 999)
    {
    Console.Write("Трёхзначное число состоит из 3х цифр, пожалуйста, введите трёхзначное число: ");
    a = Convert.ToInt32(Console.ReadLine());
    }
    return a;
}

int numA = inputNumberAAA();
Console.Write("Вторая цифра числа это: ");
Console.WriteLine(Convert.ToString(numA)[1]);

