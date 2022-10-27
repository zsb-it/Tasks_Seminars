// Напишите программу, которая
// 1. найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1:");
int numberB1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1:");
int numberK1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2:");
int numberB2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2:");
int numberK2 = Convert.ToInt32(Console.ReadLine());

double[] IntersectionPoint(double B1, double K1, double B2, double K2)
{
    int size = 2;
    double[] point = new double[size];
    int i = 0;

    point[i] = (B2 - B1) / (K1 - K2);
    i++;
    point[i] = K1 * point[i - 1] + B1;

    return point;
}

void PrintIntersectionPoint(double[] intersectionPoint)
{
    int i=0;
    Console.Write($"b1 = {numberB1}, k1 = {numberK1}, b2 = {numberB2}, k2 = {numberK2}");
    Console.Write($" - > ({intersectionPoint[i]} ; {intersectionPoint[i++]})");
}

IntersectionPoint(numberB1, numberK1, numberB2, numberK2);
PrintIntersectionPoint(IntersectionPoint(numberB1, numberK1, numberB2, numberK2));