﻿// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int numX = numA;
for (int i = 1; i < numB; i++)
{
numX = numX * numA;
}
Console.WriteLine($"Число {numA} в {numB}-ой степени это: {numX}");