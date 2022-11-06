// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinSumRow(matrix) + 1}");

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int MinSumRow(int[,] array)
{
    int minSum = 0;
    int minSumTemp = 0;
    int minRow = 0; 
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum = minSum + array[0, j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        minSumTemp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            minSumTemp = minSumTemp + array[i, j];
        }
        if (minSumTemp < minSum) 
        {
            minRow = i;
            minSum = minSumTemp;
        }
    }
    return minRow;
}