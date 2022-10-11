// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();


    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;

        double numRnd = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(numRnd, 2, MidpointRounding.ToZero);

    }

    return array;

}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }

    Console.WriteLine("]");
}


double[] arr = CreateArrayRndInt(5, 2, 10);
PrintArray(arr);


double maxValue = arr.Max();
double minValue = arr.Min();

double diff = maxValue - minValue;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива - {diff}");