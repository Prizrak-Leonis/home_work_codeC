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

void WriteMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != 0)
            {
                if (matrix[i, j] < 10)
                    Console.Write(" ");
                if (matrix[i, j] < 100)
                    Console.Write(" ");
                Console.Write(matrix[i, j] + " \t");
            }
        }
        Console.WriteLine();
    }
}


// Console.Write("Введите сколько строк треугольника Паскаля необходимо вывести на экран (от 1 до 12): ");
// int lines = Convert.ToInt32(Console.ReadLine());
int lines = 12;
int[,] trianglePaskal = new int[lines, lines];

for (int i = 0; i < lines; i++)
{
    for (int j = 0; j <= i; j++)
    {
        trianglePaskal[i, j] = Factorial(i) / (Factorial(j) * Factorial(i - j));
    }
}


WriteMatrix(trianglePaskal);
