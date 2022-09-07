// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int inputNumber()
{
    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void thirdNumber()
{
    int numA = inputNumber();
    if (numA < 100 && numA > -100)
        Console.WriteLine("Третьей цифры нет");
    else if (numA > 99)
        Console.WriteLine("Третья цифра числа " + Convert.ToString(numA)[2]);
    else
        Console.WriteLine("Третья цифра числа " + Convert.ToString(numA)[3]);
}

thirdNumber();