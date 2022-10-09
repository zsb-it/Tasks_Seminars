﻿// Напишите программу, которая
// 1. будет выдавать название дня недели по заданному номеру.

// 3 -> Среда
// 5 -> Пятница


Console.Write("Введите номер дня недели: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
switch (numberOne)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Неизвестный день недели");
        break;
}

// Второй вариант решения

// Console.Write("Введите номер дня недели: ");
// string num = Console.ReadLine();

// if (num=="1")
// {
//     Console.WriteLine("Понедельник");
// }
// else if (num=="2")
// {
//     Console.WriteLine("Вторник");
// }
// else if (num=="3")
// {
//     Console.WriteLine("Среда");
// }
// else if (num=="4")
// {
//     Console.WriteLine("Четверг");
// }
// else if (num=="5")
// {
//     Console.WriteLine("Пятница");
// }
// else if (num=="6")
// {
//     Console.WriteLine("Суббота");
// }
// else if (num=="7")
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Перебор");
// }