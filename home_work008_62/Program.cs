// Напишите программу, которая заполнит спирально массив 4 на 4.

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

int[,] InputMatrix(int[,] matrix)
{
    int count = 1;
    int pass = 0;
    while (count <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        for (int j = pass; j < matrix.GetLength(1)-pass; j++)
        {
            matrix[pass,j] = count;
            count++;
        }
        for (int i = pass+1; i < matrix.GetLength(0)-pass; i++)
        {
            matrix[i,matrix.GetLength(1)-pass-1] = count;
            count++;
        }
        for (int j = matrix.GetLength(1)-pass - 2; j >= pass ; j--)
        {
            matrix[matrix.GetLength(0)-pass-1,j] = count;
            count++;
        }
        for (int i = matrix.GetLength(0)-pass - 2; i > pass ; i--)
        {
            matrix[i,pass] = count;
            count++;
        }
        pass++;
    }
return matrix;
}


int[,] massive = new int[4, 4];
WriteMatrix(InputMatrix(massive));