// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели и я скажу является ли он выходным");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7)
{
    Console.Write("Вы ввели некорректное значение :( ");
}
if (num == 1)
{
    Console.Write("нет");
}
if (num == 2)
{
    Console.Write("нет");
}
if (num == 3)
{
    Console.Write("нет");
}
if (num == 4)
{
    Console.Write("нет");
}
if (num == 5)
{
    Console.Write("нет");
}
if (num == 6)
{
    Console.Write("да");
}
if (num == 7)
{
    Console.Write("да");
}