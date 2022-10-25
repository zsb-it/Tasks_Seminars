// Задача 25:
// Напишите цикл, который
// 1. принимает на вход два числа (A и B) и
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numberB = Convert.ToInt32(Console.ReadLine());

int degreeNumber = DegreeNumber(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = {degreeNumber}");

int DegreeNumber(int numA, int numB)
{
    int degree = 1;
    for (int i = 1; i <= numberB; i++)
    {
        degree = degree * numberA;
    }
    return degree;
}