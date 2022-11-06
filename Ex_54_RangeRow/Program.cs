// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];
FillArray(matrix);
PrintArray(matrix);
SortRow(matrix);
Console.WriteLine("Строки отсортированы по убыванию:");
PrintArray(matrix);

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SortRow(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            int minPosition = i;
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[k, j] > array[k, minPosition]) minPosition = j;
            }
            int temporary = array[k, i];
            array[k, i] = array[k, minPosition];
            array[k, minPosition] = temporary;
        }
    }
}