// Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
}

double diffMinMax(double[] array)
{
    double max = 0;
    double min = 0;
    if (array[0] < array[1])
    {
        min = array[0];
        max = array[1];
    }
    else
    {
        min = array[1];
        max = array[0];
    }

    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        else if (array[i] > max)
            max = array[i];
    }
    return max - min;
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[N];
InputArray(arr);

Console.WriteLine("Исходный массив данных: [" + string.Join("; ", arr) + "]");

Console.WriteLine("Разница между максимальным и минимальным: " + diffMinMax(arr));
