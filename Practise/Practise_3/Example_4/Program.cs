Console.Clear();

Console.Write("Введите число N: ");
double n = double.Parse(Console.ReadLine());

int i = 1;
while (i <= n)
{
    Console.Write($"{Math.Pow(i, 2)}");
    if (i != n)
    {
        Console.Write(", ");
    }
    i++;
}