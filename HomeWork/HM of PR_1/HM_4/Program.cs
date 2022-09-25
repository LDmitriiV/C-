Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());

int count = 2;
while (count <= number)
{
    Console.Write($"{count}, ");
    count = count + 2;
}