Console.Clear();

Console.Write("Введите номер четверти: ");
int i = int.Parse(Console.ReadLine());

if ((i > 0) && (i < 5))
{
    if (i == 1)
    {
        Console.WriteLine("x и y > 0");
    }
    if (i == 2)
    {
        Console.WriteLine("x < 0 и y > 0");
    }
    if (i == 3)
    {
        Console.WriteLine("x и y < 0");
    }
    if (i == 4)
    {
        Console.WriteLine("x > 0 и y < 0");
    }
}
else
{
    Console.WriteLine("Существует только 4 четверти: 1, 2, 3, 4");
}
