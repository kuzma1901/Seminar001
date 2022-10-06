// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет 12821 -> да  23432 -> да

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

int firstDigit = num / 10000;
int aDigit = num / 1000;
int secondDigit = aDigit % 10;
int bDigit = num % 100;

int fourthDigit = bDigit / 10;
int fifthDigit = num % 10;

if (firstDigit == fifthDigit && secondDigit == fourthDigit)
{
  Console.WriteLine($"{num} является полиндромом");
}
else
{
  Console.WriteLine($"{num} не является полиндромом");
}