/*  72: Заданы 2 массива: info и data. В массиве info хранятся двоичные
 представления нескольких чисел (без разделителя). В массиве data хранится
 информация о количестве бит, которые занимают числа из массива info.
 Напишите программу, которая составит массив десятичных представлений
 чисел массива data с учётом информации из массива info.
входные данные: data = {0, 1, 1, 1, 1, 0, 0, 0, 1 } 1 0. 0 0 1 .1 1 1 .0
info = {2, 3, 3, 1 }выходные данные: 1, 7, 0, 1 */


/* int[] arrayData = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] arrayInfo = { 2, 3, 3, 1 };

for (int i = 0; i < arrayInfo.Length; i++)
{
    int decNum = 0;
    
        for (int j = 0; j < arrayInfo[i]; j++)
        {
            decNum += arrayData[j] * (int)Math.Pow(2, j);
        }
    Console.Write($"{decNum}, ");
}
 Array.Reverse(arrayData); */

int[] info = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] data = { 2, 3, 3, 1};

int index = 0;
string numberAsString = string.Empty;

foreach (int value in data) 
{
    numberAsString = ""; 

    for (int i = 0; i < value; i++) 
    {
        numberAsString += info[index]; 
        index++; 
    }

int newNumber = Convert.ToInt32(numberAsString, 2);
Console.Write(newNumber + " ");
}