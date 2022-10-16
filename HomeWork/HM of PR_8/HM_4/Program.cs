/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Clear();

int[,,] matrix = new int[2, 2, 2];

FillMatrix(matrix);
PrintMatrix(matrix);

int GetUniqueValue(int[,,] matrix, int i, int j, int k)
{
    int value = default;
    bool exist = true;
    while (exist)
    {
        bool cheak = false;
        value = new Random().Next(1, 100);
        for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
        {
            if (cheak) break;
            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
            {
                if (cheak) break;
                for (int k1 = 0; k1 < matrix.GetLength(2); k1++)
                {
                    if (matrix[i1, j1, k1] == value)
                    {
                        cheak = true;
                        break;
                    }
                    if (i1 == i && j1 == j && k1 == k) exist = false;
                }
            }
        }
    }
    return value;
}

void FillMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = GetUniqueValue(matrix, i, j, k);
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],1}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}