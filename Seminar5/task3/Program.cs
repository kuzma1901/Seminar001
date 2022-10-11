// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindElemArray(int[] array, int findInt)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == findInt)
        {
            result = true;
            break;
        }
        return result;
}

int[] arr = CreateArrayRndInt(10, -5, 5);

PrintArray(arr);
Console.Write("Введите искомое число в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
if(FindElemArray(arr, num)) Console.WriteLine("число есть в массиве");
else Console.WriteLine("числа нет в массиве");