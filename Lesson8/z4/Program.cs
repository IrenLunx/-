// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных

void FillArray(int[,] array, int min = 0, int max = 6)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}

void PrintCountNumbers(int[,] array, int row, int column)
{
    int count = 0;
    int value = array[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == value) count++;
        }
    }
    Console.WriteLine($"{array[row, column]} встречается {count} раз");
}



int ExclusivElement(int[,] array, int value)
{
    for (int i = 0; i <= row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (array[i, j] == value) return 0;
        }
    }
    return 1;
}

int[,] array = new int[2, 3];
FillArray(array);
PrintArray(array);
int[] arrayTwo = new int[array.GetLength(0) * array.GetLength(1)];
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {

        if (ExclusivElement(array, i, j) == 1)
            PrintCountNumbers(array, i, j);
    }
}
