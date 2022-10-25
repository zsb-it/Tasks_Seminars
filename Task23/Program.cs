// Задача 23. Напишите программу, которая
// 1. принимает на вход число (N) и
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void Cube(int num)
{
    int count = 1;
    Console.WriteLine($"Таблица кубов чиcел от 1 до {num}");
    while (count <= num)
    {
        Console.WriteLine($"{count,5}|{Math.Pow(count,3),5}");
        count++;
    }
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);