// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(2, 6);
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

Console.WriteLine("Перемножение матриц возможно только в случае когда кол-во стобцов первой матрицы совпадает с кол-во строк вo второй");
Console.Write("Введите кол-во строк в вервой матрице: ");
int lines1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в первой матрице: ");
int colums1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во строк во второй матрице: ");
int lines2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов во второй матрице: ");
int colums2 = Convert.ToInt32(Console.ReadLine());

if (colums1 == lines2)
{
    int[,] massive1 = new int[lines1, colums1];
    int[,] massive2 = new int[lines2, colums2];
    int[,] massiveResult = new int[lines1, colums2];

    InputMatrix(massive1);
    WriteMatrix(massive1);

    InputMatrix(massive2);
    WriteMatrix(massive2);

    for (int i = 0; i < massiveResult.GetLength(0); i++)
    {
        for (int j = 0; j < massiveResult.GetLength(1); j++)
        {
            int temp = 0;
            for (int k = 0; k < colums1; k++)
            {
                temp += massive1[i,k]*massive2[k,j];
            }
        massiveResult[i,j] = temp;
        }
    }
    WriteMatrix(massiveResult);
}
else
    Console.Write("Невозможно перемножить такие матрицы");
