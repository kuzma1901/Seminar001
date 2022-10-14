// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumElementsNumber(int numb)
{
    int sum = numb % 10;
    if (numb > 0)
    {
        sum = sum + SumElementsNumber(numb / 10);
    }
    return sum;
}
int sumElem = SumElementsNumber(number);
Console.Write($"{number} -> {sumElem}");


// То же самое

// int SumOfDig(int num) //453  //45 // 4
// {
//     int result = num % 10; /// 3
//     if (num != 0) result += SumOfDig(num / 10);
//     return result ;
// }