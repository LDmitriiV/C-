﻿/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
Ограничения:
- Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
- Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода*/

Console.Clear();
Console.Clear();
Console.Write("Введите длину массива: ");
int n = int.Parse(Console.ReadLine());

int[] array = FillArray(n);
PrintArray(array);

int[] FillArray(int n)
{
    int[] array = new int[n];
    Random randGenegator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenegator.Next();
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
}