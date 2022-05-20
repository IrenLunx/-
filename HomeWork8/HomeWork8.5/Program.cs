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
            RightwardsIncreaseFillArray(
                array: array,
                indexRow: count,
                indexColumn: count,
                pozishionLastColumn: fullSize - count,
                count: array[count, count - 1]
                );
            DownIncreaseFillArray(
                array: array,
                indexRow: count + 1,
                indexColumn: fullSize - count,
                pozishionLastRow: fullSize - count,
                count: array[count, fullSize - count]
                );
            LeftwardsIncreaseFillArray(
                array: array, 
                indexRow: fullSize - count, 
                indexColumn: fullSize - count, 
                pozishionLastColumn: count, 
                count: array[fullSize - count, fullSize - count]
                );
        }
        else
        {
            if (i == 0)
                RightwardsIncreaseFillArray(
                    array: array, 
                    indexRow: count, 
                    indexColumn: count, 
                    pozishionLastColumn: fullSize - count, 
                    count: array[count, count]
                    );
            else
                RightwardsIncreaseFillArray(
                    array: array, 
                    indexRow: count, 
                    indexColumn: count, 
                    pozishionLastColumn: fullSize - count, 
                    count: array[count, count - 1]
                    );
            DownIncreaseFillArray(
                array: array, 
                indexRow: count + 1, 
                indexColumn: fullSize - count, 
                pozishionLastRow: fullSize - count, 
                count: array[count, fullSize - count]
                );
            LeftwardsIncreaseFillArray(
                array: array, 
                indexRow: fullSize - count, 
                indexColumn: fullSize - count - 1, 
                pozishionLastColumn: count, 
                count: array[fullSize - count, fullSize - count]
                );
            UpwardIncreaseFillArray(
                array: array, 
                indexRow: fullSize - count - 1, 
                indexColumn: count, 
                pozishionLastRow: count + 1, 
                count: array[fullSize - count, count]
                );
        }
        count++;
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2} ");
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