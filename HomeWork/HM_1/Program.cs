Console.Write("Введите число А ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число В ");
int b = int.Parse(Console.ReadLine());

int min = a;
int max = b;

if (a > b) 
{
    max = a; min = b;
    }
Console.Write($"max= {max}, ");
Console.Write($"min= {min}");