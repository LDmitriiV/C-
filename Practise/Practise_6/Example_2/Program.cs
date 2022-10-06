/*Задача: Напишите программу, которая принимает на вход число и
выдаёт количество цифр в числе. Использовать рекурсию
456 -> 3
78 -> 2
89126 -> 5*/

Console.Clear();
int number = int.Parse(Console.ReadLine());

Console.WriteLine(CountNumber(number));


int CountNumber(int num)
{
if (num / 10 < 1) return 1;

else return 1 + CountNumber(num/10);
}