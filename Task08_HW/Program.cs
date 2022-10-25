﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите положительное число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Чётные числа от 1 до {number}: ");

int count = 2;
while (count <= number)
{
    Console.Write($"{count} ");
    count = count + 2;
}