// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

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

int SumElementsRowArray(int[,] array, int rowArray)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum += array[rowArray, i];
    }
    return sum;
}

int NumberRowArrayMinSum(int[,] array)
{
    int row = 0;
    int minSum = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumRow = SumElementsRowArray(array, i);
        if (i == 0) minSum = sumRow;
        if (minSum > sumRow)
        {
            minSum = sumRow;
            row = i;
        }
    }
    return row;
}

Console.Write("Введите количество строк прямоугольного массива: ");
int rowArray = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов прямоугольного массива: ");
int columnArray = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] newArray = new int[rowArray, columnArray];
FillArray(newArray, -99, 100);
PrintArray(newArray);

if (rowArray != columnArray)
{
    int numberRow = NumberRowArrayMinSum(newArray);
    Console.WriteLine($"Номер строки с наименьшей суммой элементов - {numberRow + 1}.");
}
else Console.WriteLine("Ваш массив не является прямоугольным!");