/* Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.

5
0
7
8
-2
-2 -> 2

5
-1
-7
567
89
223-> 3 */

Console.Clear();
Console.Write("Введите число М: ");
int m = int.Parse(Console.ReadLine());
int[] arr = new int[m];
Console.WriteLine("Введите числа через Enter: ");
int[] array = ParseArray(m);
PositiveDigit(array);
Console.Write($"Количество цифр больше 0: {PositiveDigit(array)}");


int[] ParseArray(int m)
{
    for (int i = 0; i < m; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int PositiveDigit(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
 
    return count;
}