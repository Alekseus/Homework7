﻿//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Clear();

double[,] GetMatrix(int row, int col)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 10) Console.Write($" {array[i, j]}  ");
            else Console.Write($"  {array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

double[] GetArithmeticMean(double[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            result[j] = sum / array.GetLength(1);
        }
    }
    return result;
}

void PrintArray(double[] array)
{
    Console.WriteLine("------------------------------------------------------------------------------------" );
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

int row = 7;
int col = 5;


double[,] matrix = GetMatrix(row, col);
PrintMatrix(matrix);
double[] arithmeticMean = GetArithmeticMean(matrix);
PrintArray(arithmeticMean);

