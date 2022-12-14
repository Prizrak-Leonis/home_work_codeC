// Треугольник Паскаля. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.

int Factorial(int n)
{
    if (n == 0 || n == 1)
        return 1;
    int factorial = 2;
    for (int i = 3; i <= n; i++)
    {
        factorial *= i;
    }
    return factorial;
}

void PrintTrianglePascal(int[,] matrix)
{
    int middleLine = Console.WindowWidth/2;
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.CursorLeft = middleLine-(1+4*i);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != 0)
            {
                if (matrix[i, j] < 10)
                    Console.Write(" ");
                if (matrix[i, j] < 100)
                    Console.Write(" ");
                Console.Write(matrix[i, j] + "     ");
            }
        }
        Console.WriteLine();
    }
}


Console.Write("Введите сколько строк треугольника Паскаля необходимо вывести на экран (от 1 до 13): "); // формата int не хватает для вычисления факториала больше 13!
int lines = Convert.ToInt32(Console.ReadLine());
while (lines < 1 && lines > 13)
{
    Console.Write("Возможно вывести только от 1 до 13 строк, сколько выводить? ");
    lines = Convert.ToInt32(Console.ReadLine());
}

int[,] trianglePaskal = new int[lines, lines];
for (int i = 0; i < lines; i++)
{
    for (int j = 0; j <= i; j++)
    {
        
        trianglePaskal[i, j] = Factorial(i) / (Factorial(j) * Factorial(i - j));
    }
}

PrintTrianglePascal(trianglePaskal);
