﻿// Задача 21
// Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату Х точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

Console.Write("Введите координату Х точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Distance(xa, ya, za, xb, yb, zb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние от точки A до точки B: {distance}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return dist;
}