// Задача 48: Задайте двумерный массив размера i на j,
// каждый элемент в массиве находится по формуле: Aij = i+j.
// Выведите полученный массив на экран.
// i = 3, j = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixSumIndex(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {

        for (int j = 0; j < matrix.GetLength(1); j++) // columns
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] array2D = CreateMatrixSumIndex(10, 10);
PrintMatrix(array2D);