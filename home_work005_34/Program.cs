// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

int even(int[]array)
{
    int count = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i]%2 ==0)
            count++;
    }
    return count;
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[N];
InputArray(arr);

Console.WriteLine("Исходный массив данных: [" + string.Join(", ", arr) + "]");

Console.WriteLine("Кол-во чётный чисел в массиве: "+even(arr));
