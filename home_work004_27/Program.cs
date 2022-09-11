// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Хотите я посчитаю сумму всех цифр в названном Вами числе?");
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (numA > 0)
{
    sum += numA % 10;
    numA /= 10;
}
Console.WriteLine("Сумма цифр вашего числа равна: " + sum);
