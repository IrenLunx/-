// Заполните спирально массив 4 на 4

void RightwardsIncreaseFillArray(int[,] array, int indexRow, int indexColumn, int pozishionLastColumn, int count)
{
    for (int i = indexColumn; i <= pozishionLastColumn; i++)
    {
        array[indexRow, i] = count + 1;
        count++;
    }
}

void DownIncreaseFillArray(int[,] array, int indexRow, int indexColumn, int pozishionLastRow, int count)
{
    for (int i = indexRow; i <= pozishionLastRow; i++)
    {
        array[i, indexColumn] = count + 1;
        count++;
    }
}

void LeftwardsIncreaseFillArray(int[,] array, int indexRow, int indexColumn, int pozishionLastColumn, int count)
{
    for (int i = indexColumn; i >= pozishionLastColumn; i--)
    {
        array[indexRow, i] = count + 1;
        count++;
    }
}

void UpwardIncreaseFillArray(int[,] array, int indexRow, int indexColumn, int pozishionLastRow, int count)
{
    for (int i = indexRow; i >= pozishionLastRow; i--)
    {
        array[i, indexColumn] = count + 1;
        count++;
    }
}

void SpiralFillArray(int[,] array)
{
    int lastRow = array.GetLength(0) - 1;
    int lastColumn = array.GetLength(1) - 1;
    int startRow = 0;
    int startColumn = 0;
    int i = 1;
    RightwardsIncreaseFillArray(array, startRow, startColumn, lastColumn, array[startRow, startColumn]);
    DownIncreaseFillArray(array, startRow + i, lastColumn, lastRow, array[startRow, lastColumn]);
    LeftwardsIncreaseFillArray(array, lastRow, lastColumn - i, startColumn, array[lastRow, lastColumn]);
    UpwardIncreaseFillArray(array, lastRow - i, startColumn, startRow + i, array[lastRow, startColumn]);
    RightwardsIncreaseFillArray(array, startRow + i, startColumn + i, lastColumn - i, array[startRow + i, startColumn]);
    DownIncreaseFillArray(array, lastRow - i, lastColumn - i, lastRow - i, array[startRow + i, lastColumn - i]);
    LeftwardsIncreaseFillArray(array, lastRow - i, startColumn + i, startColumn + i, array[lastRow - i, lastColumn - i]);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j], 2} ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] newArraySquare = new int[4, 4];
SpiralFillArray(newArraySquare);
PrintArray(newArraySquare);