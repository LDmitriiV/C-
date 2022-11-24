/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();
Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);
int result = 0;

if (m < n)
{
    int i = m;
    Recursion(m, n, i);
}
else
{
    int i = n;
    Recursion(m, n, i);
}

Console.Write(result);

void Recursion(int m, int n, int i)
{
    if (m < n)
    {
        if (i >= m && i <= n)
        {
            result = result + i;
            i++;
            Recursion(m, n, i);
        }
    }
    if (m > n)
    {
        if (i <= m && i >= n)
        {
            result = result + i;
            i++;
            Recursion(m, n, i);
        }
    }
}
