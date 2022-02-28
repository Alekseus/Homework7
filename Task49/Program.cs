//Показать двумерный массив размером m×n, заполненный вещественными числами.


Console.Clear();

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            Console.Write($"  {arr[i, j]}");
        }
        Console.WriteLine();

    }

}
void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble() * 100;
        }
    }
}

double[,] array = new double [3, 5];

FillArray(array);
PrintArray(array);
