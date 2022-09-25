// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 7);
        }
    }
}

void WriteMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "  ");
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

Console.Write("Введите кол-во бросаемых за раз кубиков: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во бросков кубиков: ");
int lines = Convert.ToInt32(Console.ReadLine());
int[,] massive = new int[lines, colums];
InputMatrix(massive);
WriteMatrix(massive);
int lineMinSumm = lineMinimalSumm(massive);
Console.WriteLine("Бросок с минимальным значением: ");
for (int i = 0; i < massive.GetLength(1) - 1; i++)
{
    Console.Write(massive[lineMinSumm, i] + ", ");
}
Console.Write(massive[lineMinSumm, massive.GetLength(1) - 1]);