﻿// Задача 18. Напишите программу, которая
// по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти.

Console.WriteLine("Введите номер четверти");
Console.Write("Четверть: ");
string quart = Console.ReadLine();

string coordinates = Coordinates(quart);
Console.WriteLine(coordinates);

string Coordinates(string quarter)
{
    if (quarter == "1") return "x > 0 и y > 0";
    if (quarter == "2") return "x < 0 и y > 0";
    if (quarter == "3") return "x < 0 и y < 0";
    if (quarter == "4") return "x > 0 и y < 0";
    return "Ошибочка";
}