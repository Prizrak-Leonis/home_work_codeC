// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    // array[i] = new Random().Next(0, 101);
    Console.Write("Введите " + (i + 1) + "-е число массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
