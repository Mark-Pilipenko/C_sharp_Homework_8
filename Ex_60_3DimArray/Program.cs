// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите C: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] matrix = new int[a, b, c];
FillArray3(matrix);
PrintArray3(matrix);

bool CheckUnique(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number)
                {
                    return false;
                }
            }
        }
    }
    return true;
}

void FillArray3(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
               while (matrix[i, j, k] == 0)
                {
                    int number = new Random().Next(10, 100);
                    if (CheckUnique(matrix, number) == true)
                    {
                        matrix[i, j, k] = number;
                    }
                }
            }
        }
    }
}

void PrintArray3(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

// void PrintArray3(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }
