Console.Write("Введите число N ");
int number = int.Parse(Console.ReadLine());

for (int count = number * (-1); count <= number; count++)
Console.Write(count + $" ");
