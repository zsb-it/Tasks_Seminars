// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и
// 2. выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

// Второй вариант - Тут будет переполнение переменной

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int MultNumbers(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult *= i;
    }
    return mult;
}

int multNumbers=MultNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} -> {multNumbers}");