// Задача 22. Таблица квадратов

void TableSqr(int arg)
{
    int i = 1;
    if (arg > 0)
    {
    while (i <= arg)
    {
        Console.WriteLine($"{i}     {Math.Pow(i, 2)}");
        i++;
    }    
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
TableSqr(num);
