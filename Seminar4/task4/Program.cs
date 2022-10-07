//Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// Индексы:
//  0 1 2 3 4 5 6 7
// [1,0,1,1,0,1,0,0]
// int[] array = new int[8];
// array[0] = 1;
// array[1] = 3;
// array[2] = 6;
// array[3] = 4;
// array[4] = 7;

int[] array = new int[8];

FillArrayRandom();
PrintArray();

void FillArrayRandom()
{
Random rnd = new Random();
for (int i = 0; i <= array.Length - 1; i++) array[i] = rnd.Next(1, 56);
}

void PrintArray()
{
Console.Write($"[");
for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
Console.Write($"{array[array.Length - 1]}]");
}


// Console.Write("Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] arrayGlobal = new int[num];

// FillArrayRandom(arrayGlobal);
// PrintArray(arrayGlobal);

// void FillArrayRandom(int[] array)
// {
// Random rnd = new Random();
// for (int i = 0; i <= array.Length - 1; i++) array[i] = rnd.Next(1, 66);
// }

// void PrintArray(int[] array)
// {
// Console.Write("[");
// for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
// Console.Write($"{array[array.Length - 1]}]");
// }

