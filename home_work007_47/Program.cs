// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void WriteMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0)
                Console.Write(" ");
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 200 - 100, 1);
        }
    }
}

Console.Write("Введите кол-во строк в матрице: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в матрице: ");
int M = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[N, M];
InputMatrix(matrix);
WriteMatrix(matrix);
