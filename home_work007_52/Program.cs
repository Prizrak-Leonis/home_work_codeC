// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк в матрице: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в матрице: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] massive = new int[lines, colums];
InputMatrix(massive);
WriteMatrix(massive);
Console.WriteLine();
for (int j = 0; j < colums; j++)
{
    double summ = 0;
    for (int i = 0; i < lines; i++)
    {
        summ += massive[i,j];
    }
    Console.Write(Math.Round(summ/lines,2) + " \t");
}
