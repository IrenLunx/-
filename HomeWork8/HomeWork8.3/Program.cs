// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

int[,] ProductMatricesArray(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] arrayThree = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    for (int j = 0; j < arrayThree.GetLength(0); j++)
    {
        for (int k = 0; k < arrayThree.GetLength(1); k++)
        {
            int sum = 0;
            int result = 0;
            for (int i = 0; i < arrayOne.GetLength(1); i++)
            {
                result = arrayOne[j, i] * arrayTwo[i, k];
                sum += result;
            }
            arrayThree[j, k] = sum;
        }
    }
    return arrayThree;
}

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
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] arrayMatricesA = new int[4, 2];
int[,] arrayMatricesB = new int[2, 3];
FillArray(arrayMatricesA, 1, 20);
Console.WriteLine("Первая матрица:");
PrintArray(arrayMatricesA);
FillArray(arrayMatricesB, 1, 20);
Console.WriteLine("Вторая матрица:");
PrintArray(arrayMatricesB);
int[,] arrayMatricesC = ProductMatricesArray(arrayMatricesA, arrayMatricesB);
Console.WriteLine("Произведение двух матриц:");
PrintArray(arrayMatricesC);