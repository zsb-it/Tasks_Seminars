// Задача 42: Напишите программу, которая
// будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// первый вариант

int Binary(int num)
{
    int temp = 0;
    int count = 1;
    while (num > 0) 
    {
        temp = temp + num % 2 * count; 
        num = num / 2; 
        count = count * 10; 
    }
    return temp;
}

int binary = Binary(number);
Console.WriteLine($"{number} -> {binary}");

// второй вариант

// string DecToBin(int number)
// {
//     string result = String.Empty;
//     while (number > 0)
//     {
//         result = Convert.ToString(number % 2) + result;
//         number = number / 2;
//     }
//     return result;
// }

// string decToBin = DecToBin(num);
// Console.WriteLine(decToBin);
