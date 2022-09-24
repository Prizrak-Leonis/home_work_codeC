// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] sortLine(int[,] matrix)
{
    for (int l = 0; l < matrix.GetLength(0); l++)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            int max = i;
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[l,j] > matrix[l,max])
                    max = j;
            }
            if (max != i)
            {
                int temp = matrix[l,i];
                matrix[l,i] = matrix[l,max];
                matrix[l,max] = temp;
            }
        }
    }
    return matrix;
}


Console.Write("Введите кол-во строк в матрице: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в матрице: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] massive = new int[lines, colums];
InputMatrix(massive);
WriteMatrix(massive);

WriteMatrix(sortLine(massive));