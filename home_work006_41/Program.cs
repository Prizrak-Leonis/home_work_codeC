// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите кол-во вводимых чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите {i + 1}-е числo: ");
    int N = Convert.ToInt32(Console.ReadLine());
    if (N > 0)
        count++;
}
Console.WriteLine("Чисел больше 0 введено: " + count);

