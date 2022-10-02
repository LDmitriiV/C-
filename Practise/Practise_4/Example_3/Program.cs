/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, -3] -> нет
-3; массив [6, 7, 19, 345, -3] -> да*/
Console.Clear();

Console.Write("введите число: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[10];
FillArray(array);
PrintArray(array);
if (FindNunberInArray(array, num))
Console.Write($"число {num} присутствует в массиве");
else
Console.Write($"число {num} отсутсвует в массиве");

bool FindNunberInArray(int[] array, int num)
{
for (int i = 0; i < 10; i++)
{
if (array[i] == num)
{
return true;
}
}
return false;
}

void FillArray(int[] array)
{
Random randGenegator = new Random();
for (int i = 0; i < 10; i++)
{
array[i] = randGenegator.Next(0, 10);
}
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