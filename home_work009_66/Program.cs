// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Сумма натуральных элементов в промежутке от M до N");
Console.Write("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int summNumbers(int n, int m)
{
    if (n == m)
        return n;
    return summNumbers(n + 1, m) + n;
}

if (N > M)
    Console.WriteLine("Сумма всех элементов = " + summNumbers(M, N));
else
    Console.WriteLine("Сумма всех элементов = " + summNumbers(N, M));