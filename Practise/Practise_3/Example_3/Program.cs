Console.Clear();

Console.Write("Введите координаты Х для А: ");
double xa = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Y для А: ");
double ya = double.Parse(Console.ReadLine());

Console.Write("Введите координаты Х для B: ");
double xb = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Y для B: ");
double yb = double.Parse(Console.ReadLine());

double l = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
Console.Write($"Длина отрезка = {l:f2}");