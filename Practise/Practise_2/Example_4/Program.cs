Console.Clear();

Console.Write("Введите число А ");
int a = int.Parse(Console.ReadLine());

if ((a % 7 == 0) && (a % 23 == 0))
    Console.Write($" число {a} кратное 7 и 23");
else
    Console.Write($" число {a} не кратно 7 и 23");