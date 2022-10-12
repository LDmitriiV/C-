/* Задача 49: Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, и замените эти элементы на их квадраты.
 */

 Console.Clear();
 
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int [m,n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ReplaceArray(array);
PrintArray(array);
 
 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");                      
        }
        Console.WriteLine();
    }
}
 
void ReplaceArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+= 2)
    {
        for (int j = 0; j < array.GetLength(1); j+= 2)
        {
            array[i,j] = array[i,j] * array[i,j];                      
        }
    }
}
 
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
        }
        
    }
}