﻿// Задача 53: Задайте двумерный массив.
// Напишите программу,  которая поменяет местами
// первую и последнюю строку массива.

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

void PrintReplasingStrings(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = 0;
        temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }    
}

int[,] createMatrixRndInt = CreateMatrixRndInt(5, 7, 1, 100);
PrintMatrix(createMatrixRndInt);

Console.WriteLine("");

PrintReplasingStrings(createMatrixRndInt);
PrintMatrix(createMatrixRndInt);