// Задача 10: Напишите программу, которая
// 1. принимает на вход трёхзначное число и
// 2. на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int twoDigitNum = number / 10;
    int lastDigit = twoDigitNum % 10;
    Console.WriteLine($"Вторая цифра числа -> {lastDigit}");
}
else Console.WriteLine("Число не трёхзначное");