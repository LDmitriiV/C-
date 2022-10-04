/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Clear();
Console.Write("Введите длину массива: ");

int n = int.Parse(Console.ReadLine());
int[] array = FillArray(n);
int quantity = EvenQuantity(array);
PrintArray(array);

int EvenQuantity(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result = result + 1;
        }
    }
    return result;
}

int[] FillArray(int n)
{
    int[] array = new int[n];
    Random randGenegator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenegator.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
    Console.Write($"Количество четных чисел равно {quantity}");
}