// Задайте двумерный массив. Напишите программу, которая меняет местами первую и последнюю строку массива

void FillArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] SwapStringArray(int[,] array)
{
    int[,] differenceArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 1; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            differenceArray[i, j] = array[i, j];
        }
    }

    for (int i = 0; i < array.GetLength(1); i++)
    {
        differenceArray[0, i] = array[array.GetLength(0) - 1, i];
        differenceArray[array.GetLength(0) - 1, i] = array[0, i];
    }

    return differenceArray;
}

int[,] arrayOne = new int[4, 6];
FillArray(arrayOne, -10, 10);
PrintArray(arrayOne);
int[,] arrayTwo = SwapStringArray(arrayOne);
PrintArray(arrayTwo);