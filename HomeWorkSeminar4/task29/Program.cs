// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

FillArrayRandom();
PrintArray();

void FillArrayRandom()
{
Random rnd = new Random();
for (int i = 0; i <= array.Length - 1; i++) array[i] = rnd.Next(1, 99);
}

void PrintArray()
{
Console.Write($"[");
for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
Console.Write($"{array[array.Length - 1]}]");
}
