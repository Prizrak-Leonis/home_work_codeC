// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Хотите я назову все чётные числа от 1 до вашего числа?");
Console.Write("Введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());
while (numN < 2)
{
    Console.Write("Введите число больше 1: ");
    numN = Convert.ToInt32(Console.ReadLine());
}    
int n = 2;
while (n <= numN )
{
if (n%2 == 0)
    Console.Write(n + " ");
n++;
}
