// Задайте двумерный массив размером m * n, заполненный случайными вещественными числами

void FillDoubleArray(float[,] array, float minValue, float maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (float) new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
}

void PrintDoubleArray(float[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j], 8:f2}");
        }
        System.Console.WriteLine();
    }
}

float[,] newDoubleArray = new float[5, 4];
FillDoubleArray(newDoubleArray, -200.77f, 200.88f);
PrintDoubleArray(newDoubleArray);