// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 999);
Console.WriteLine($"Случайное трехзначное число = {num}");

int firstDigit = num / 100;
int thirdDigit = num % 10;
Console.Write($"Получившееся число без второй цифры: ");
Console.Write($"{firstDigit}");
Console.Write($"{thirdDigit}");