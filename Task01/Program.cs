﻿// Напишите программу, которая 
// 1. на вход принимает два числа и
// 2. проверяет, является ли первое число квадратом второго.

// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne == numberTwo * numberTwo)
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");