// Задача 54.1 : 
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит элементы по убыванию (или возрастанию).

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];
FillArray(matrix);
Console.WriteLine("Исходный массив:");
PrintArray(matrix);
Console.WriteLine("Перевели в одномерный:");
int[] array = ToOneDimArray(matrix);
PrintOneDimArray(array);
SelectionSort(array);
Console.WriteLine("Отсортированный одномерный:");
PrintOneDimArray(array);
ToMatrix(array, matrix);
Console.WriteLine("Отсортированный:");
PrintArray(matrix);


void FillArray(int[,] matrix)           //Заполнение матрицы случайными числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] matrix)      //Печать матрицы
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

int[] ToOneDimArray(int[,] matrix)      //Перевод матрицы в одномерный массив
{
    int[] oneDimArray = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            oneDimArray[i * matrix.GetLength(1) + j] = matrix[i,j];
        }
        
    }
    return oneDimArray;
}

void PrintOneDimArray(int[] array)      //Печать одномерного массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)     //Сортировка одномерного массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j]< array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void ToMatrix(int[] array, int[,] matrix)       //Обратный перевод одномерного массива в матрицу
{
      for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = array[i * matrix.GetLength(1) + j];
        }
    }
}