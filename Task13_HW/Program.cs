// Задача 13: Напишите программу, которая
// 1. выводит третью цифру заданного числа
// 2. или сообщает, что третьей цифры нет.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int lastDigit = number % 10;
    Console.WriteLine($"Третья цифра числа -> {lastDigit}");
}
else Console.WriteLine("Третьей цифры нет");