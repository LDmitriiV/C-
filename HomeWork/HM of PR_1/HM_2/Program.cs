Console.Write("Введите число А ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число В ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите число C ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write($"max = {max}");
