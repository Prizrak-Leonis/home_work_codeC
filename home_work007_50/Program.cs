// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
        }
    }
}

void WriteMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
                Console.Write(" ");
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк в матрице: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в матрице: ");
int M = Convert.ToInt32(Console.ReadLine());
int[,] massive = new int[N, M];
InputMatrix(massive);

Console.Write("Введите позицию строки элемента в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца элемента в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (n > massive.GetLength(0) || m > massive.GetLength(1) || n <= 0 || m <= 0)
    Console.WriteLine("Такого элемента нет");
else Console.WriteLine("Искомое значение: " + massive[n - 1, m - 1]);
WriteMatrix(massive);