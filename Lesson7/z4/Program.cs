// Задайте двумерный массив, заполните его случайными числами. Найдите сумму элементов на главной диагонали 
// (главная диагональ - это те элементы, которые имеют индекс 0,0 1,1...)

void FillRandomArrey(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    PrintArray(array);
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

string SumDiagonalIndex(int[,] array)
{
    string result = String.Empty;
    int sumIndex = 0;
    int minLength = Math.Min(array.GetLength(0), array.GetLength(1));
    for (int j = 0; j < minLength; j++)
    {
        sumIndex += array[j, j];
        if (j != 0)
            result += " + " + array[j, j];
        else
            result += array[j, j];
    }
    result += " = " + sumIndex;
    return result;
}

int[,] newArray = new int[50000, 60000];
FillRandomArrey(newArray, -10, 10);
System.Console.WriteLine("Сумма элементов массива на главной диагонали: " + SumDiagonalIndex(newArray));