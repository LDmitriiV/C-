/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();

Console.Write("Введите координаты Х для А: ");
double xa = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Y для А: ");
double ya = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Z для А: ");
double za = double.Parse(Console.ReadLine());

Console.Write("Введите координаты Х для B: ");
double xb = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Y для B: ");
double yb = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Z для B: ");
double zb = double.Parse(Console.ReadLine());

double l = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
Console.Write($"Длина отрезка = {l:f2}");