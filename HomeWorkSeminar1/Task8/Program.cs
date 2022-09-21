// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введи число и я скажу все четные числа до него");
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine()); 
for (int a = 1; a < x+1; a++)       
if (a%2==0)            
Console.WriteLine(a);