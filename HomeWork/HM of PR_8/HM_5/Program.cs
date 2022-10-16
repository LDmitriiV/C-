/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Clear();

int[,] mattrix = new int[4, 4];

CreateMattrix(mattrix);
WriteMattrix(mattrix);

void CreateMattrix(int[,] mattrix, int i = 0, int j = 0)
{
    for (int temp = 1; temp <= mattrix.GetLength(0) * mattrix.GetLength(1); temp++)
    {
        mattrix[i, j] = temp;
        if (i <= j + 1 && i + j < mattrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= mattrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > mattrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

void WriteMattrix(int[,] mattrix)
{
    for (int i = 0; i < mattrix.GetLength(0); i++)
    {
        for (int j = 0; j < mattrix.GetLength(1); j++)
        {
            if (mattrix[i, j] / 10 <= 0)
                Console.Write($" {mattrix[i, j]} ");

            else Console.Write($"{mattrix[i, j]} ");
        }
        Console.WriteLine();
    }
}