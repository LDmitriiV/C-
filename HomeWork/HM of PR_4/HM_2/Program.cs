/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Ограничения:
- Должна быть отдельная функция, которая возвразает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода*/

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int count = n.ToString().Length;

int res = Power(n);

Console.WriteLine($"Сумма цифр в числе {n} = {res}");

int Power(int n)
{
    int result = 0;
    
    int digit;
    for (int i = 0; i < count; i++)
    {
        digit = n - n % 10;
        result = result + (n - digit);
        n = n / 10;
    }
    return result;
}