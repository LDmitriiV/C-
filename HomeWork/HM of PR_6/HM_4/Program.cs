/* Задача 2*. Написать программу, которая принимает от пользователя положительные 
числа и считает среднее значение этих чисел.
Ввод числе осуществляется до тех пор, пока пользовател не введёт -1. 
Ввод чисел и расчёт должен происходит в рекурсии
1
2
3
4
-1
-> 2,5 */

Console.Clear();
 
double average = CalcAverageFromConsole();
Console.WriteLine(average);
 
 
double CalcAverageFromConsole(double sum = 0, int count = 0)
{
    Console.Write("Введите десятичное число: ");
    double number = double.Parse(Console.ReadLine()!);
 
    if (number == -1)
        return sum / count;
    else
        return CalcAverageFromConsole(sum + number, count + 1);
}