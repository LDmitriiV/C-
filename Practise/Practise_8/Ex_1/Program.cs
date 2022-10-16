/* Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.*/

Console.Clear();

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);
 
Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[row,coloumn];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
RepleceRowArray(matrix);
PrintArray(matrix);


void RepleceRowArray(int[,] array)
{
for (int j = 0; j < array.GetLength(1); j++)
{
int temp = array[0 , j] ;
array[0 , j] = array[array.GetLength(1) - 1 , j];
array[array.GetLength(1) - 1 , j] = temp;
}
}

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i, j]} ");
}
Console.WriteLine("");
}
}

void FillArray(int[,] array)
{
Random generator = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = generator.Next(1, 10);
}
}
}