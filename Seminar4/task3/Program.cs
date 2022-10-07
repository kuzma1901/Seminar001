// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int MakeFact(int num)
{
    int fact = 1;
    for (int i = 1; i <= number; i++)
    {
        fact = fact * i;
        // fact *= i; то же самое 
    }
    return fact;
}
int makeFact = MakeFact(number);
Console.WriteLine($"Факториал, введенного числа -> {makeFact}");

// Метод while

// Console.Write("Введите целое положительное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int MakeFact (int num)
// {
//   int fact = num;
//   while (num > 1)
//   {
//      fact = fact * (num - 1);
//      num --;
//   }
//   return fact;
// }
// int makefact = MakeFact(number);
// Console.WriteLine ($"Факториал, введенного числа -> {makefact}");