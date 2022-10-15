/* Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1
7 -> такого числа в массиве нет */

Console.Clear();

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

SearchElementOfArray(array);

void SearchElementOfArray(int[,] array)
{
    Console.Write("Введите позицию элемента в строке массива: ");
    int i1 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите позицию элемента в столбце массива: ");
    int j1 = int.Parse(Console.ReadLine()!);


    if (i1 <= array.GetLength(0))
    {
        if (j1 <= array.GetLength(1))
            Console.WriteLine($"Этот элемент = {array[i1, j1]}");
        else
            Console.WriteLine("Такого элемента в массиве нет");
    }
    else
        Console.WriteLine("Такого элемента в массиве нет");
}

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

void FillArray(int[,] array)
{
    Random generator = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 10);
        }
    }
}