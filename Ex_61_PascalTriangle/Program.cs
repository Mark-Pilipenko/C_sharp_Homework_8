// Задача 61 Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

// ........1
// ......1 1
// ....1 2 1
// ..1 3 3 1
// .1 4 6 4 1

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Первые {n} строк треугольника Паскаля:");
PascalTriangle(n);

void PascalTriangle(int row)
{
    for (int str = 1; str <= row; str++)
    {
        for (int i = 0; i <= (row - str); i++)
        {
            Console.Write(" ");
        }
        int space = 1;
        for (int j = 1; j <= str; j++)
        {
            Console.Write(" ");
            Console.Write(space);
            space = space * (str - j) / j;
        }
        Console.WriteLine(" ");
    }
}