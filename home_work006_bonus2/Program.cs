// Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки. Входной файл INPUT.TXT содержит строку, состоящую из N символов (1 ≤ N ≤ 8), символы - буквы английского алфавита и цифры. В выходной файл OUTPUT.TXT выведите в каждой строке по одной перестановке. Перестановки можно выводить в любом порядке. Повторений и строк, не являющихся перестановками исходной, быть не должно.

Console.Write("Введите набор символов от 1 до 8: ");

string simbols = "" + Console.ReadLine();
while (simbols.Length > 8)
{
    Console.Write("Пожалуйста введите не больше 8 символов: ");
    simbols = "" + Console.ReadLine();
}
int count = 0;
string savedSimbols = "";
void PrintVar(string simbolsLine)
{
    int i = 0;
    while (i < simbolsLine.Length)
    {
        savedSimbols = savedSimbols + simbolsLine[i];
        string restSimbols = "";
        for (int j = 0; j < simbolsLine.Length; j++)
        {
            if (j != i)
                restSimbols = restSimbols + simbolsLine[j];
        }
        if (simbolsLine.Length == 1)
        {
            Console.WriteLine(savedSimbols);
            count++;
        }
        else
        {
            PrintVar(restSimbols);
        }
        string tempSimbolsLine = savedSimbols;
        savedSimbols = "";
        for (int k = 0; k < tempSimbolsLine.Length - 1; k++)
        {
            savedSimbols = savedSimbols + tempSimbolsLine[k];
        }
        i++;
    }
}
Console.WriteLine("Возможные варианты:");
PrintVar(simbols);
Console.WriteLine("Кол-во различный комбинаций: " + count);
