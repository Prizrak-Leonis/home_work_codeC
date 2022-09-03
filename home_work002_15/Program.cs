// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int inputDay()
{
    Console.Write("Введите номер дня недели: ");
    int d = Convert.ToInt32(Console.ReadLine());
    while (d < 1 || d > 7)
    {
        Console.Write("В неделе только 7 дней, пожалуйста введине порядковый номер дня недели от 1 до 7: ");
        d = Convert.ToInt32(Console.ReadLine());
    }
    return d;
}

void holiday()
{
    int day = inputDay();
    if (day == 6 || day == 7)
        Console.WriteLine("Выходной");
    else
        Console.WriteLine("Будний");
}

holiday();
