/* Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя. */

Console.Clear();

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);

double[,] matrix = new double[row, coloumn];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeRowsAndColumns(matrix);
PrintArray(matrix);

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("");
    }
}

void FillArray(double[,] matrix)
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

double[,] ChangeRowsAndColumns(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            double m = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = m;
        }
    }
    return matrix;
}
