Console.Write("Введите число А ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число В ");
int b = int.Parse(Console.ReadLine());

int min = a;
int max = a;

if (a > max) max = a; min = b;
if (b > max) max = b; min = a;


Console.Write($"max= {max}, ");
Console.Write($"min= {min}");