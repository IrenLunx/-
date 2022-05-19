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

void SquareSpiralFillArray(int[,] array)
{
    int sizeCycle = (array.GetLength(0) + array.GetLength(1)) / 2;
    int count = 0;
    int fullSize = array.GetLength(0) - 1;
    for (int i = 0; i < sizeCycle; i++)
    {
        if (sizeCycle - i == 1)
        {
            RightwardsIncreaseFillArray(array, count, count, fullSize - count, array[count, count - 1]);
            DownIncreaseFillArray(array, count + 1, fullSize - count, fullSize - count, array[count, fullSize - count]);
            LeftwardsIncreaseFillArray(array, fullSize - count, fullSize - count, count, array[fullSize - count, fullSize - count]);
        }
        else
        {
            if (i == 0)
                RightwardsIncreaseFillArray(array, count, count, fullSize - count, array[count, count]);
            else
                RightwardsIncreaseFillArray(array, count, count, fullSize - count, array[count, count - 1]);
            DownIncreaseFillArray(array, count + 1, fullSize - count, fullSize - count, array[count, fullSize - count]);
            LeftwardsIncreaseFillArray(array, fullSize - count, fullSize - count - 1, count, array[fullSize - count, fullSize - count]);
            UpwardIncreaseFillArray(array, fullSize - count - 1, count, count + 1, array[fullSize - count, count]);
        }
        count++;
    }

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
if (newArraySquare.GetLength(0) != newArraySquare.GetLength(1))
    Console.WriteLine("Массив не является квадратным!");
else
{
    SquareSpiralFillArray(newArraySquare);
    PrintArray(newArraySquare);
}