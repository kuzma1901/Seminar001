Console.WriteLine("Введите два числаи мы узнаем является ли первое число квадратом второго");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int sqr_b = b * b;
if (sqr_b == a)
{
    Console.WriteLine($"Да, первое число {a} - это квадрат второго числа {b}");
}
else
{
    Console.WriteLine($"Нет, первое число {a} - это не квадрат второго числа {b}. квадрат числа {b} - это {sqr_b}");
}