// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

double Akerman(double m, double n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Akerman(m - 1, 1);
    return Akerman(m - 1, Akerman(m, n - 1)); // m > 0, n > 0
}

Console.WriteLine(Akerman(5, 3));