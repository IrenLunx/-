// Напишите программу, которая принимает на вход позиции элемента в двумерном массиве 
// и возвращает значение этого элемента или же указание, что такого элемента нет

void FillRandomArray(int[,] array, int minValue, int maxValue)
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
            Console.Write($"{array[i,j], 4} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ElementValueArray(int[,] array, int row, int column)
{
    if (array.GetLength(0) > row && array.GetLength(1) > column) 
        Console.WriteLine("Элемент массива равен " + array[row, column]);
    else 
        Console.WriteLine("Данного элемента в массиве нет!");
}

Console.Write("Введите позицию элемента в строке (позиции считаются с 0): ");
int rowArray = int.Parse(Console.ReadLine());
Console.Write("Введите позицию элемента в столбце (позиции считаются с 0): ");
int columnArray = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] newArray = new int[5, 8];
FillRandomArray(newArray, -100, 101);
PrintArray(newArray);
ElementValueArray(newArray, rowArray, columnArray);