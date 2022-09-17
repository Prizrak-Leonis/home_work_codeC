// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали. Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – количество строк и столбцов матрицы. В каждой из последующих N строк записаны M целых чисел – элементы матрицы. Все числа во входных данных не превышают 100 по абсолютной величине. В выходной файл OUTPUT.TXT выведите матрицу, полученную транспонированием исходной матрицы относительно горизонтали.
void WriteMatrix(int[,] mx)
{
    Console.WriteLine();
    for (int i = 0; i < mx.GetLength(0); i++)
    {
        for (int j = 0; j < mx.GetLength(1); j++)
        {
            Console.Write($"{mx[i, j]} ");
        }
        Console.WriteLine();
    }
}

void TranspMatrixGorizont(int[,] mx)
{
    for (int i = 0; i < mx.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < mx.GetLength(1); j++)
        {
            int temp = mx[i, j];
            mx[i, j] = mx[mx.GetLength(0) - i - 1, j];
            mx[mx.GetLength(0) - i - 1, j] = temp;
        }
    }
    WriteMatrix(mx);
}

Console.Write("Введите кол-во строк в матрице: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов в матрице: ");
int M = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[N, M];
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10, 100);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}

TranspMatrixGorizont(matrix);