// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Console.Write("Введите числа: ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int amount = 0;
 
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         amount++;
//     }
// }
 
// Console.WriteLine($"Введено {amount} чисел больше нуля");


Console.WriteLine("Введите три числа");
Console.Write("Введите первое: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье: ");
int с = Convert.ToInt32(Console.ReadLine());


int count = default;
 
for (int i = 0; i < count; i++)

{
    if (a > 0) count++;
}

Console.WriteLine($"Введено {count} чисел больше нуля");