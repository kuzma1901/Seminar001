//  Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int count = num.ToString().Length;

if (num < 0) Console.WriteLine("Вы ввели некорректное значение");

for (int i= 0; i < count; i++)
{
    int dig = num % 10;
    num = num / 10;
    sum = sum + dig;
}
Console.WriteLine($"Сумма цифр введенного числа = {sum}");