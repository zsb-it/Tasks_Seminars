﻿// Напишите программу, которая
// 1. принимает на вход трёхзначное число и
// 2. на выходе показывает последнюю цифру этого числа

// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int lastDigit = number % 10;
    Console.WriteLine($"Последняя цифра числа -> {lastDigit}");
}
else Console.WriteLine("Число не трёхзначное");