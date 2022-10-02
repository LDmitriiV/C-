/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

Console.Clear();
int[] array = new int[11];

FillArray(array);
PrintArray(array);
int[] newArray = Product(array);
PrintArray(newArray);

int[] Product(int[] arr)
{
int[] newarr;
if (arr.Length % 2 == 0)
{
newarr = new int[arr.Length/2];
for (int i = 0; i < arr.Length/2; i++)
{
newarr[i] = arr[i]*arr[arr.Length - 1- i];
}
}
else
{
newarr = new int[arr.Length/2 + 1];
for (int i = 0; i < arr.Length/2 + 1; i++)
{
if (i == arr.Length/2)
newarr[i] = arr[i];
else
newarr[i] = arr[i]*arr[arr.Length - 1- i];

}
}
return newarr;
}

void FillArray(int[] array)
{
Random randGenegator = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = randGenegator.Next(0, 20);
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