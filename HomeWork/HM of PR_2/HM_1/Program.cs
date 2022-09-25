Console.Clear();

Console.Write("Введите трехзначное число А ");
int a = int.Parse(Console.ReadLine());

if ((99 < a) && (a < 1000)) 
    Console.Write($"Вторая цифра числа {a} равна {a / 10 % 10}");
else
    Console.Write($"Введите трехзначное число!");