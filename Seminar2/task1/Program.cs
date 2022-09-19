// Напишите программу, которая выводит
// 1. случайное число из отрезка [10, 99]
// 2. наибольшую цифру числа.
// 3. вывод результата

// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
int firstDigit = number / 10;
int secondDigit = number % 10;

Console.WriteLine($"случайное число отрезка 10-99 это {number}");
if(firstDigit > secondDigit) Console.WriteLine($"наибольшая цифра числа {number} => {firstDigit}");
else Console.WriteLine($"наибольшая цифра числа {number} => {secondDigit}");
