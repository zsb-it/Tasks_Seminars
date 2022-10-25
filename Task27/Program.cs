// Задача 27: Напишите программу, которая
// 1. принимает на вход число и
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int NumbersSum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

int numbersSum = NumbersSum(number);
Console.WriteLine($"Сумма цифр в числе {number} -> {numbersSum}");