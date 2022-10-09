// Напишите программу, которая
// 1. на вход принимает число (N), а
// 2. на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

int counter = -number;
while (counter <= number)
{
    Console.Write($"{counter} ");
    counter++;
}

