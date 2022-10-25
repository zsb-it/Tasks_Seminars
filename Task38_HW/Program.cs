// Задача 38:
// 1. Задайте массив вещественных чисел.
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble()*100, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] -> ");
}

double DifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double difference = Math.Round(max - min, 1);
    return difference;
}

double[] arr = CreateArrayRndDouble(5);
PrintArray(arr);

double differenceMaxMin = DifferenceMaxMin(arr);
Console.WriteLine(differenceMaxMin);