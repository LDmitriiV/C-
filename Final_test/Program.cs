Console.Clear();

Console.WriteLine("Введите значения через запятую");
string input = Console.ReadLine()!;
string[] array = input.Split(new Char[] {','});
string[] finalArray = ArrayLessThreeDigits(array);
PrintArray(finalArray);

string[] ArrayLessThreeDigits(string[] array)
{   
    string[] arr1 = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr1[count] = array[i];
            count++;
        }
    }
    string[] arr2 = new string[count];
    for (int j = 0; j < count; j++)
    {
        arr2[j] = arr1[j];
    }
    return arr2;
}

void PrintArray(string[] finalArray)
{
    Console.Write("[");
    for (int i = 0; i < finalArray.Length; i++)
    {
        Console.Write(finalArray[i]);
        if (i != finalArray.Length-1)
        {
            Console.Write(", ");
        }
        
    }
    Console.WriteLine("]"); 
}
