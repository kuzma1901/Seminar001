Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7 || num < 1)
{
    Console.Write("Вы ввели некорректное значение :( ");
}
if (num == 1)
{
    Console.Write("Это понедельник");
}
if (num == 2)
{
    Console.Write("Это вторник");
}
if (num == 3)
{
    Console.Write("Это среда");
}
if (num == 4)
{
    Console.Write("Это четверг");
}
if (num == 5)
{
    Console.Write("Это пятница");
}
if (num == 6)
{
    Console.Write("Это суббота");
}
if (num == 7)
{
    Console.Write("Это воскресенье");
}