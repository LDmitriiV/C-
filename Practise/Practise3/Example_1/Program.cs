Console.Clear();

Console.Write("Введите X ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите Y ");
int y = int.Parse(Console.ReadLine());

if (x > 0)
{
    if (y > 0)
    {
        Console.WriteLine("Четверть 1");    
    }
    else
    {
        Console.WriteLine("Четверть 4");    
    }
}
else
{
    if (y > 0)
    {
        Console.WriteLine("Четверть 2");
    }
    else
    {
        Console.WriteLine("Четверть 3");
    }
}   