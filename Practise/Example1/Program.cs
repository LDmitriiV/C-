Console.Write("Введите число А ");
string inputA = Console.ReadLine();
int numberA = int.Parse(inputA);

Console.Write("Введите число В ");
string inputB = Console.ReadLine();
int numberB = int.Parse(inputB);


if (numberB * numberB == numberA) 
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}

