int[] arr ={1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i =0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);


void SelectionSortMin(int[] array)
{
 for (int i = 0; i < array.Length - 1; i++)
 {
 int minPosition = i;
 for (int j = i + 1; j < array.Length; j++)
 {
 if (array[j] < array[minPosition])
 {
 minPosition = j;
 }
 }
 int temporary = array[i];
 array[i] = array[minPosition];
 array[minPosition] = temporary;
 }
}
SelectionSortMin(arr);
PrintArray(arr);

void SelectionSortMax(int[] array)
{
 for (int i = 0; i < array.Length - 1; i++)
 {
 int maxPosition = i;
 for (int j = i + 1; j < array.Length; j++)
 {
 if (array[j] > array[maxPosition])
 {
 maxPosition = j;
 }
 }
 int temporary = array[i];
 array[i] = array[maxPosition];
 array[maxPosition] = temporary;
 }
}
SelectionSortMax(arr);
PrintArray(arr);