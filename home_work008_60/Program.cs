// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void inputMassive3d(int[,,] massive)
{
    int[] tempMassive = new int[massive.GetLength(0) * massive.GetLength(1) * massive.GetLength(2)];
    int l = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int k = 0; k < massive.GetLength(2); k++)
            {
                bool flag = true;
                int tempElem = 0;
                while (flag)
                {
                    tempElem = new Random().Next(10, 100);
                    int count = 0;
                    foreach (int item in tempMassive)
                    {
                        if (tempElem == item)
                            count++;
                    }
                    if (count == 0)
                        flag = false;
                }
                massive[i, j, k] = tempElem;
                tempMassive[l] = tempElem;
                l++;
            }
        }
    }
}

void WriteMassive3d(int[,,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int k = 0; k < massive.GetLength(2); k++)
                Console.Write($"{massive[i, j, k]} ({i}, {j}, {k}) \t");
            Console.WriteLine();
        }
    }
}

int[,,] massive3d = new int[3, 4, 5];
if (massive3d.GetLength(0) * massive3d.GetLength(1) * massive3d.GetLength(2) <= 90)
{
    inputMassive3d(massive3d);
    WriteMassive3d(massive3d);
}
else
    Console.WriteLine("Для заполнения такого массива не хватит двухзначных числе");