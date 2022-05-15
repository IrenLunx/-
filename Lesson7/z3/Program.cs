// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты

void FillArrayRandom(int[,] array, int minValue, int maxValue)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void SwapEvenIndexArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) + 1; i += 2)
    {
        if (i != 0)
        {
            for (int j = 2; j < array.GetLength(1) + 1; j += 2)
            {
                array[i - 1, j - 1] *= array[i - 1, j - 1];
            }
        }
    }
}

int[,] newArray = new int[4, 7];
FillArrayRandom(newArray, -5, 5);
PrintArray(newArray);
SwapEvenIndexArray(newArray);
PrintArray(newArray);
