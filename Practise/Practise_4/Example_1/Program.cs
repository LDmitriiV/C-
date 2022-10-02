Console.Clear();
 
void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(0, 2);
    }
}
 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите размер массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);
 
int[] array = new int[arrayLenght];
 
FillArray(array);
PrintArray(array);