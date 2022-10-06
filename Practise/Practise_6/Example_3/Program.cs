/* Задача: Напишите программу, которая будет рекурсивно выводить каждый элемент 
массива в консоль*/

int[] CreateArray()
{
Console.Write("Введи размерность массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
return array;
}

void FillArray(int[] array)
{
Random randGenerator = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = randGenerator.Next(-99, 100);
}
}

void PrintArray(int[] array)
{
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
}

void RecPrintArray(int[] array, int index = 0)
{
if (index < array.Length)
{
Console.Write($"{array[index]} ");
index++;
RecPrintArray(array, index);
}
}
Console.Clear();
int[] array = CreateArray();
FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write("Рекурсивный: ");
RecPrintArray(array);