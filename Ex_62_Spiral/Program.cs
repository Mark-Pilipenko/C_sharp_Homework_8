﻿Console.Write("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine()!);
int[,] array = new int[length, length];
FillSnakeArray(array);
PrintArrayPlusZero(array);

void FillSnakeArray(int[,] matrix)
{
    int i = 0;
    int j = 0;
    for (int n = 1; n <= length * length; n++)
    {
        array[i, j] = n;
        if (i <= j + 1 && i + j < length - 1) j++;
        else if (i < j && i + j >= length - 1) i++;
        else if (i >= j && i + j > length - 1) j--;
        else i--;
    }
}

void PrintArrayPlusZero(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < 10) Console.Write($"0{matrix[i, j]} ");
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}