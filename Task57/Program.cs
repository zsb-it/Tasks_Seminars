﻿// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.WriteLine($"{matrix[i, j],3} ");
        };
    }
}

int[] NewArray(int[,] matrix)
{
    int[] newArray = new int[matrix.Length];
    int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                newArray[k] = matrix[i,j];
                k++;
            }
        }

    return newArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}.");
    }
}

void CountElements(int[] array)
{
    int num = array[0]; //1
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == num) count++; //3
        else
        {
            Console.WriteLine($"{num} встречается {count} раз");
            num = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{num} встречается {count} раз");
}


int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

int[] array = NewArray(array2D);
Array.Sort(array);
PrintArray(array);

Console.WriteLine();
CountElements(array);
