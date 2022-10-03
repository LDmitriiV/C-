/*Задача 37: Напишите метод, который объединяет 2 массива в 1. 
[5, 18, 123, 6, 2] + [1, 2, 3] = [5, 18, 123, 6, 2, 1, 2, 3]*/

int[] ParseToArray(string str1, string str2)

{
string str = str1 + ' ' + str2;
string[] stringArray = str.Split(" ");
int[] result = new int[stringArray.Length];

for (int i = 0; i < stringArray.Length; i++)
{
result[i] = int.Parse(stringArray[i]);
}

return result;
}

Console.Write("Введите числа первого массива через пробел: ");
string firstArray = Console.ReadLine()!;

Console.Write("Введите числа второго массива через пробел: ");
string secondArray = Console.ReadLine()!;

int[] newArray = ParseToArray(firstArray, secondArray);

Console.WriteLine(String.Join(", ", newArray));

/*int[] ConcatArray(int[] array1, int[] array2)
{
int[] resultArray = new int[array1.Length + array2.Length];
int counter = 0;

for (int i = 0; i < array1.Length; i++)
{
resultArray[counter] = array1[i];
counter++;
}
for (int i = 0; i < array2.Length; i++)
{
resultArray[counter] = array2[i];
counter++;
}

return resultArray;
}*/