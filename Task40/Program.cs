// Задача 40 Напишите программу, которая
// 1. принимает на вход три числа и
// 2. проверяет, может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int numberC = Convert.ToInt32(Console.ReadLine());

bool CheckTriangle(int numA, int numB, int numC)
{
     if (numA < numB + numC && numB < numC + numA && numC < numA + numB) return true;
    else return false;
}

if (CheckTriangle(numberA, numberB, numberC)) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник не существует");
