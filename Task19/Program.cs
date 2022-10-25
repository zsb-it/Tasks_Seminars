// Задача 19. Напишите программу, которая
// 1. принимает на вход пятизначное число и
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    int num1 = number % 10;
    int num2 = number / 10 % 10;
    int num3 = number / 100 % 10;
    int num4 = number / 1000 % 10;
    int num5 = number / 10000 % 10;

    string result = num1 == num5 && num2 == num4 ? "Да" :"Нет";
    Console.WriteLine(result);
}
else Console.WriteLine("Введенное число не является пятизначным");