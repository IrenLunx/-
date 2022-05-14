// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Amn = m + n. Выведите полученный массив на экран 

void PrintArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        System.Console.WriteLine();
    }
}

int[,] FillSumArray(int stringsArray, int columnArray)
{
    int[,] array = new int[stringsArray, columnArray];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = i + j;
    }
    return array;
}

int[,] arraySumIndex = FillSumArray(4, 5);
PrintArray(arraySumIndex);