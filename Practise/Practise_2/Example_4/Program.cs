Console.Clear();

Console.Write("Введите число А ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число В ");
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
    Console.Write($"{a} кратное {b}");
else
    Console.Write($"остаток {a % b}");