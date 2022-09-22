Console.Write("Введите число N ");
int number = int.Parse(Console.ReadLine());

int count = number * (-1);
while (count < number)
{
    Console.Write(count + $", ");
    count++;
}
Console.Write(count);
