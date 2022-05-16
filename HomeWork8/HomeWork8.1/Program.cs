// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

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
            Console.Write($"{array[i, j], 4} ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void ArrangeDescendingArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 1; j < array.Length; j++)
        {
            if (array[j - 1] < array[j])
            {
                int help = array[j];
                array[j] = array[j - 1];
                array[j - 1] = help;
            }
        }
    }
}

void ArrangeDescendingArrayBivariate(int[,] array)
{
    int[] arrayOneDimensional = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayOneDimensional[j] = array[i, j];
        }
        ArrangeDescendingArray(arrayOneDimensional);
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = arrayOneDimensional[k];
        }
    }
}

int[,] newArray = new int[5, 6];
FillArrayRandom(newArray, -99, 100);
PrintArray(newArray);
ArrangeDescendingArrayBivariate(newArray);
PrintArray(newArray);
