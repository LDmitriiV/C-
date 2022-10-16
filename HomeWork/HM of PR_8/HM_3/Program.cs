/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
 произведение двух матриц.
Например, даны 2 матрицы:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49 */

Console.Clear();

Console.Write("Введите число строк Матрицы1: ");
int row1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов Матрицы1 (строк Матрицы2): ");
int coloumn1Row2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов Матрицы2: ");
int coloumn2 = int.Parse(Console.ReadLine()!);

int[,] matrix1 = new int[row1, coloumn1Row2];
int[,] matrix2 = new int[coloumn1Row2, coloumn2];
int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

FillArray(matrix1);
FillArray(matrix2);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
Multiplication(matrix1, matrix2, matrix3);
PrintArray(matrix3);

void Multiplication(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            matrix3[i, j] = sum;
        }
    }
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