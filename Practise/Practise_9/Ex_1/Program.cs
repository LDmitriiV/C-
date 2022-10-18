/* Задача 70:
Напишите программу, которая печатает последовательность чисел, 
где каждое следующее равно сумме двух предыдущих. 
На вход принимает 3 числа: n1, n2 и N, где n1 n2 - первые числа последовательности,
N – длина последовательности 
3 и 4, N = 5 -> 3 4 7 11 18 
6 и 10, N = 4 -> 6 10 16 26 */

Console.Clear();

Console.Write("Введите n1: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите n2: ");
int n2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

int[] array = new int[N];
array[0] = n1;
array[1] = n2;

for (int i = 2; i < N; i++)
{
array[i] = array[i - 2] + array[i - 1];
}

PrintArray(array);

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
}