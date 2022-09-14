// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.
// Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai, а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100). Выведите полученную последовательность.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void ChangeArray(int[] array, int shift)
{
    if (shift < 0)
        shift = shift + array.Length;
    int[] temp = new int[array.Length];

    for (int i = 0; i < shift; i++)
        temp[i] = array[array.Length - shift + i];
    for (int i = shift; i < array.Length; i++)
        temp[i] = array[i - shift];

    Console.WriteLine("Массив после сдвига:    [" + string.Join(", ", temp) + "]");
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите величину сдвига: ");
int K = Convert.ToInt32(Console.ReadLine());
while (K < -N || K > N)
{
    Console.Write("Введите величину сдвига не превышающую размер самого массива: ");
    K = Convert.ToInt32(Console.ReadLine());
}

int[] arr = new int[N];
InputArray(arr);
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", arr) + "]");

ChangeArray(arr, K);
