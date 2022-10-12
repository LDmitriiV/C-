/* Задайте двумерный массив. Найдите сумму элементов, находящихся на 
главной диагонали (с индексами (0,0); (1;1) и т.д.)
 */
Console.Clear();

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали = {SumOfDiaArray(array)}");


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumOfDiaArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i += 1)
    {
        for (int j = 0; j < array.GetLength(1); j += 1)
        {
            if (i == j)
            {
                sum += array[i, j];
            }
        }
    }
    return sum;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }

    }
}