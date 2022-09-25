Console.Clear();

Console.Write("Введите число А ");
int a = int.Parse(Console.ReadLine());

int count = a.ToString().Length;

if (count >= 3)
    {
        string number = a.ToString();
        Console.Write($"Третья цифра числа {number[2]}");
        }
else
    Console.Write($"Третьей цифры нет!");
    