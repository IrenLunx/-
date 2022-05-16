// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

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
            Console.Write($"{array[i, j], 3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ColumnsArrayArithmeticMedium(int[,] array)
{
    int sum = 0;
    int count = 0;
    int arithmeticMedium = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
            count++;
        }
        arithmeticMedium = sum / count;
        if (i != 1) Console.WriteLine($"Среднее арифметическое элементов в {i + 1} столбце = {arithmeticMedium}.");
        else Console.WriteLine($"Среднее арифметическое элементов во {i + 1} столбце = {arithmeticMedium}.");
    }
}

int[,] newArray = new int[6, 7];
FillArray(newArray, -20, 100);
PrintArray(newArray);
ColumnsArrayArithmeticMedium(newArray);