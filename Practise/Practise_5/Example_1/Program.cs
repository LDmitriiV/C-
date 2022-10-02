Console.Clear();
Console.WriteLine("Введите числа через пробел");
 
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);
 
Console.WriteLine($"Положительная сумма: {PositiveSum(array)}");
Console.Write($"Отрицательная сумма: {NegativeSum(array)}");
 
 int[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];
 
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
 
    return result;
}
 
int PositiveSum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count += array[i];
    }
 
    return count;
}
int NegativeSum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            count += array[i];
    }
 
    return count;
}