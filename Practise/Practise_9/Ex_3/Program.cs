/* Задача 72:
Задан массив, в котором хранится двоичное представление числа.
Нужно вывести его десятичное представление {0,1,1,1,1} -> 15*/

Console.Clear();
int[] doubleNum = {0, 1, 1, 1, 1};
Array.Reverse(doubleNum);
double result = 0;

for (int i = 0; i < doubleNum.Length; i++)
{
    result+= Math.Pow(2, i) * doubleNum[i];
}
Console.WriteLine(result);

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