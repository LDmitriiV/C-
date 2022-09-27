/*
Задача 19 (branch task_1)
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();

Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());
if ((n >= 10000) && (n < 100000))
{
    int digit1 = n / 10000;
    int digit5 = n % 10;

    if (digit1 == digit5)
    {
        n = n / 10;
        int digit2 = n / 100 % 10;
        int digit4 = n % 10;
        if (digit2 == digit4)
        {
            Console.WriteLine("Да");
        }
    }
    else
    {
        Console.WriteLine("Нет");
    }

}
else
{
    Console.WriteLine("Некорректное число, введите пятизначное число!");
}