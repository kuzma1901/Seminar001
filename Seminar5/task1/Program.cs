// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

// Задаем массив:

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

// Ищем сумму общим методом:

int[] GetSumPositiveNegativeElem(int[] array)
{
    int sumPositive = default;
    int sumNegative = default;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i];
        else sumPositive += array[i];
    }
    return new int[] { sumPositive, sumNegative };
}


// Ищем сумму двумя отдельными методами:

int GetSumPositiveElem(int[] array)
{
    int sumPositive = default;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) sumPositive += array[i];
    return sumPositive;
}
int GetSumNegativeElem(int[] array)
{
    int sumNegative = default;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) sumNegative += array[i];
    return sumNegative;
}
// Размер массива

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);

// Вывод результат в консоль общего метода (не желательно)

int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativeElem[1]}");

// Вызов результата в консоль по двум методам

int sumPosit = GetSumPositiveElem(arr);
int sumNegat = GetSumNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPosit}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegat}");

// Массив вещественных чисел

// double[] CreateArrayRndInt(int size, int min, int max)
// {
//     double[] array = new double[size];
//     var rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.NextDouble() * (max - min) + min;

//     }
    
//     return array;
// }
// void PrintArray(double[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }

//     Console.WriteLine("]");
// }

// double[] arr = CreateArrayRndInt(5, 2, 10);
// PrintArray(arr);
