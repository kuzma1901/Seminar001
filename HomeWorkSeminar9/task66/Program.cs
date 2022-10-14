// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M:  ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n)
{
    int sum = default;
    int firstNum = m;
    int lastNum = n;
    if (m > n)
    {
        firstNum = n;
        lastNum = m;
    }
    if (m == n) return 0;
    sum += (lastNum + firstNum) * (lastNum - firstNum + 1) / 2;
    return sum;
}

int sumNumb = SumNumbers(numberM, numberN);
Console.WriteLine($"Сумма элементов заданного промежутка - {sumNumb}");