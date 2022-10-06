Console.Clear();
 
int number = int.Parse(Console.ReadLine()!);
 
Console.WriteLine($"Sum: {RecSum(number)}");
 
 
 
 
int RecSum(int number)
{
    if (number > 1)
    {
        return number + RecSum(number - 1);
    }
    else
    {
        return 1;
    }
}