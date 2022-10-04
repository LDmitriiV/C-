/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();
Console.Write("Введите длину массива: ");
int n = int.Parse(Console.ReadLine());
double[] array = FillArray(n);
double difference = DifferenceMaxMin(array);
PrintArray(array);

double DifferenceMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    double result = max - min;
    return result;
}

double[] FillArray(int n)
{
    double[] array = new double[n];
    Random randGenegator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenegator.NextDouble();
    }
    return array;
}

void PrintArray(double[] array)
{
    double count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]:f3}");
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
    Console.Write($"Разница между максимальным и минимальным элементами массива равна {difference:f3}");
}