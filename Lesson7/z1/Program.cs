// Задайте двумерный массив размером m * n, заполненный случайными целыми числами

void FillArrayRandom(int[,] array, int minValue, int maxValue)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    }
}

void PrintArrayRandom(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        System.Console.WriteLine();
    }
}

int m, n;
System.Console.WriteLine("Введите количество строк (m): ");
m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов (n): ");
n = Convert.ToInt32(Console.ReadLine());

int[,] randomTwoArray = new int[m, n];
FillArrayRandom(randomTwoArray, -30, 31);
PrintArrayRandom(randomTwoArray);