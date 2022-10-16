/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка (нумерация строк начинается с 1)*/

Console.Clear();

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[row, coloumn];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.Write($"Cтроки с наименьшей суммой элементов ({SearchOfLowestSum(matrix)}) - ");
RowsWithLowestSum(matrix);

int SearchOfLowestSum(int[,] matrix)
{
    int sumLine = SumElementsOfRow(matrix, 0);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int tempSumLine = SumElementsOfRow(matrix, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
        }
    }
    return sumLine;
}

void RowsWithLowestSum(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (SearchOfLowestSum(matrix) == SumElementsOfRow(matrix, i))
            Console.Write($"{i + 1}, ");
    }
}

int SumElementsOfRow(int[,] matrix, int i)
{
    int sumLine = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumLine += matrix[i, j];
    }
    return sumLine;
}

void FillArray(int[,] matrix)
{
    Random generator = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = generator.Next(1, 10);
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