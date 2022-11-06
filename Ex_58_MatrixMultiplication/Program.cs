// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// А В
// 1 4 | 3 5
// 3 5 | 1 2
// Результирующая матрица будет:
// С
// 7 13
// 14 25

Console.Write("Введите количество строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrixA = new int[m, n];
int[,] matrixB = new int[n, l];
FillArray(matrixA);
Console.WriteLine("Матрица A:");
PrintArray(matrixA);
Console.WriteLine();
FillArray(matrixB);
Console.WriteLine("Матрица B:");
PrintArray(matrixB);
Console.WriteLine();

int[,] matrixC = MultiplicateMatrix(matrixA, matrixB);
Console.WriteLine("A x B:");
PrintArray(matrixC);

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

int[,] MultiplicateMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix[i,j] = 0;
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrix[i,j] = matrix[i,j] + matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return matrix;
}