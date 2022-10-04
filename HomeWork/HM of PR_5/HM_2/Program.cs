/* Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих на 
нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
Console.Write("Введите длину массива: ");

int n = int.Parse(Console.ReadLine());

int[] array = FillArray(n);
int sum = SumUnevenNumbers(array);
PrintArray(array);

int SumUnevenNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result = result + array[i];
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
        array[i] = randGenegator.Next(0, 100);
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
    Console.Write($"Сумма элементов на нечетных позициях равна {sum}");
}