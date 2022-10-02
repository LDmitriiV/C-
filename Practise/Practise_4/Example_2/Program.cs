/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/
Console.Clear();

int[] array = CreateArray();
PrintArray(array);
RevertArray(array);
PrintArray(array);

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
Console.WriteLine();
}

int[] CreateArray()
{
int[] array = {2,-5, -8, 4, 5};
return array;
}

void RevertArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = -array[i];
}
}