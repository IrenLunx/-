// Задайте двумерный массив размером m * n, заполненный случайными вещественными числами

void FillDoubleArray(double[,] array, double minValue, double maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 1000;
        }
    }
}

void PrintDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("{0:f3} ", array[i, j]);
        }
    }
}

double[,] newDoubleArray = new double[5, 4];
FillDoubleArray(newDoubleArray, -10.6, 10.8);
PrintDoubleArray(newDoubleArray);