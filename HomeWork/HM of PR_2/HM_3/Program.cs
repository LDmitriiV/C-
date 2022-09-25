Console.Clear();

Console.Write("Введите число А ");
int a = int.Parse(Console.ReadLine());

if ((5 < a) && (a < 8))
    Console.Write("Да, это выходной день!");
else if ((0 < a) && (a < 6))
    Console.Write("Нет, это будний день!");
    else
        Console.Write("введите корректную цифру от 1 до 7 включительно!");    