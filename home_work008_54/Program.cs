// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int lineMinimalSumm(int[,] matrix)
{
    int summMin = 0;
    int lineMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i, j];
        }
        if (i == 0)
            summMin = summ;
        else if (summ < summMin)
        {
            summMin = summ;
            lineMin = i;
        }
    }
    return lineMin;
}

Console.Write("Введите кол-во строк в матрице: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в матрице: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] massive = new int[lines, colums];
InputMatrix(massive);
WriteMatrix(massive);
int lineMinSumm = lineMinimalSumm(massive);
Console.WriteLine();
Console.Write("Строка с минимальной суммой всех значений: ");
for (int i = 0; i < massive.GetLength(1) - 1; i++)
{
    Console.Write(massive[lineMinSumm, i] + ", ");
}
Console.Write(massive[lineMinSumm, massive.GetLength(1) - 1]);