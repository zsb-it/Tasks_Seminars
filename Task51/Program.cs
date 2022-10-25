// Задача 51:
// 1. Задайте двумерный массив.
// 2. Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.

int SumElements(int[,] matrix)
{
    int sum = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i, j];
        }
    }
    return sum;
}


int SumElements2(int[,] matrix)
{
    int sum = default;
    int length = 0;
    if (matrix.GetLength(0) > matrix.GetLength(1)) length = 1;
    for (int i = 0; i < matrix.GetLength(length); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

//  int[,] array2D = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(array2D);

int sumElements = SumElements2(array2D);
Console.WriteLine(sumElements);
