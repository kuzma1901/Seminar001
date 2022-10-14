// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите число M:  ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int numberN = Convert.ToInt32(Console.ReadLine());

void DiapNumbers(int numM, int numN)
{
    if (numM < numN)
    {
        DiapNumbers(numM, numN - 1);
        Console.Write($"{numN} ");
    }
    if (numM > numN)
    {
        Console.Write($"{numM} ");
        DiapNumbers(numM - 1, numN);

    }
    if (numM == numN) Console.Write($"{numM} ");
}
DiapNumbers(numberM, numberN);
