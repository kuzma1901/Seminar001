// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);
if (b.Length > 2)
{
  Console.WriteLine("третья цифра -> " + b[2]);
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}