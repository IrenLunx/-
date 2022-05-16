// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

int UniqueNumberArray3D(int[,,] array, int minValue, int maxValue)
{
    int number = new Random().Next(minValue, maxValue);
    int i = 0;
    while (i < array.GetLength(0))
    {
        for (int a = 0; a < array.GetLength(0); a++)
        {
            for (int b = 0; b < array.GetLength(1); b++)
            {
                for (int c = 0; c < array.GetLength(2); c++)
                {
                    if (number == array[a, b, c])
                    {
                        number = new Random().Next(minValue, maxValue);
                        return number;
                    }
                }
            }
        }
        i++;
    }
    return number;
}

void FillArray3D(int[,,] array, int minValue, int maxValue)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                array[a, b, c] = UniqueNumberArray3D(array, minValue, maxValue);
            }
        }
    }
}

void PrintArray3D(int[,,] array)
{
    for (int a = 0; a < array.GetLength(2); a++)
    {
        for (int b = 0; b < array.GetLength(0); b++)
        {
            for (int c = 0; c < array.GetLength(1); c++)
                Console.Write($"{array[b, c, a],3} ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void IndexsElementsArray3D(int[,,] array)
{
    Console.WriteLine("Индексы массива: строка, столбец, блок ([0, 0, 0]):");
    for (int a = 0; a < array.GetLength(2); a++)
    {
        for (int b = 0; b < array.GetLength(0); b++)
        {
            for (int c = 0; c < array.GetLength(1); c++)
            {
                Console.WriteLine($"[{b}, {c}, {a}] Элемент = {array[b, c, a]}");
            }
        }
    }
}

int[,,] newArray = new int[2, 2, 2];
FillArray3D(newArray, 1, 10);
PrintArray3D(newArray);
IndexsElementsArray3D(newArray);