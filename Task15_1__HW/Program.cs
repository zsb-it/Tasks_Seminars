// Задача 15: Напишите программу, которая
// 1. принимает на вход цифру, обозначающую день недели, и
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Вариант решения 2

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
{
    Console.WriteLine("Нет");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Неизвестный день недели");
}