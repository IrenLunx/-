// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя

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
            System.Console.Write($"{array[i, j], 4}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

bool SwapArrayRowColumn(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
        return false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int help = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = help;
        }
    }
    return true;
}

int[,] arraySwap = new int[5, 6];
FillArray(arraySwap, -10, 10);
PrintArray(arraySwap);
if (SwapArrayRowColumn(arraySwap))
    PrintArray(arraySwap);
else
    Console.WriteLine("Количество строк и столбцов отличается, замена невозможна!");