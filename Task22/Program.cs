// Задача 22. Напишите программу, которая
// 1. принимает на вход число (N) и
// 2. выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;

// while (count <= number)
// {
//     Console.WriteLine(Square(count));
//     count++;
// }

// string Square(int num)
// {
//     return ($"{num} -> {num*num}");
// }



// Второй вариант

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// Square(number);

// void Square(int num)
// {
//     int count = 1;
//     while (count <= num)
//     {
//         int square = count * count;
//         Console.WriteLine($"{count} {square}");
//         count++;
//     }
// }



// Третий вариант

void SquareTable(int num)
{
    int index = 1;
    Console.WriteLine($"Таблица квадратов чивел от 1 до {num}");
    while (index <= num)
    {
        Console.WriteLine($"|{index,4}|{Math.Pow(index,2),4}|");
        index++;
    }
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
SquareTable(number);