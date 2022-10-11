// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int number = 45;
ConvertToBin(number);

void ConvertToBin(int num)
{
    if (num == 0) return;
    ConvertToBin(num / 2);
    Console.Write(num % 2);
}

// С запросом числа

// Console.Write("Введите целое положительное число: ");
// int numA = Convert.ToInt32(Console.ReadLine());

// void ConvertToBin(int num)
// {
//     if (num == 0) return;

//     ConvertToBin(num / 2);
//     Console.Write(num % 2);
// }
// ConvertToBin(numA);