// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M:  ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int numberN = Convert.ToInt32(Console.ReadLine());


int MethodAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return MethodAkkerman(m - 1, 1);
    return MethodAkkerman(m - 1, MethodAkkerman(m, n - 1));
}

MethodAkkerman (numberM, numberN);
Console.WriteLine($"Результат - {MethodAkkerman(numberM, numberN)} ");