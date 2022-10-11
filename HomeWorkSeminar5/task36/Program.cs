// Задача 36:
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);

    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SumOddElem(int[] array)
{
    int sumOdd = default;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 1) sumOdd += array[i];

    return sumOdd;
}
int[] arr = CreateArrayRndInt(5, 1, 10);
PrintArray(arr);
int resultSum = SumOddElem(arr);
Console.WriteLine($"Сумма элементов на нечетных позициях {resultSum}");