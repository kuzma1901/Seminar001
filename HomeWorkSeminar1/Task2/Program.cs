// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введи 2 числа и я скажу какое из них большее");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write($"число {a} - большее, а число {b} - меньшее");
}
if (b > a)
{
    Console.Write($"число {b} - большее, а число {a} - меньшее");
}
if (a == b)
{
    Console.Write($"числа не могут быть равны, введи неравные числа");
}