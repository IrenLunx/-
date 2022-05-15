// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива

void FillArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,100);
        }
    }
}

void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j], 4}");
        }
        System.Console.WriteLine();
    }
}

int[,] DeleteRowAndColumn(int[,]array)
{
    int[,] resultArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int min = array[0, 0];
    int indexMinRow = 0;
    int indexMinColoumn = 0;
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                indexMinRow = i;
                indexMinColoumn = j;
            }
        }
    }
    int shiftRow = 0;
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        if (i == indexMinRow) shiftRow = 1;
        int shiftColomn = 0;
        
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            if (j == indexMinColoumn) shiftColomn = 1;
            resultArray[i, j] = array[i + shiftRow, j + shiftColomn];
        }
    }
    //System.Console.WriteLine(indexMinRow + " " + indexMinColoumn);
    return resultArray;
}

int[,] array1 = new int[5, 6];

FillArray(array1);
PrintArray(array1);
System.Console.WriteLine();
int[,] array2 = DeleteRowAndColumn(array1);
PrintArray(array2);