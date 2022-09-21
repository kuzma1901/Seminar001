// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введи 3 числа и я скажу какое из них большее");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.Write($"число {a} - большее");
}
if (b > a && b > c)
{
    Console.Write($"число {b} - большее");
}
if (c > a && c > b)
{
    Console.Write($"число {c} - большее");
}