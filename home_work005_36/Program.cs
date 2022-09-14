// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);
}

int oddPosSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[N];
InputArray(arr);

Console.WriteLine("Исходный массив данных: [" + string.Join(", ", arr) + "]");

Console.WriteLine("Сумма элементов на нечётных позициях в программе (чётных позициях для человека): " + oddPosSum(arr));