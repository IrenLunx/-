// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

int CheckSpecialNumber(int[,,] array, int minValue, int maxValue)
{
    int number = new Random().Next(minValue, maxValue);
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                if (array[a, b, c] == number)
                    number = CheckSpecialNumber(array, minValue, maxValue);
            }
        }
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
                array[a, b, c] = CheckSpecialNumber(array, minValue, maxValue);
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
                Console.Write($"{array[b, c, a], 3} ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void IndexsElementsArray3D(int[,,] array)
{
    Console.WriteLine("Индексы массива: строка, столбец, блок ([0, 0, 0]):");
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                Console.WriteLine($"[{a}, {b}, {c}] Элемент = {array[a, b, c]}");
            }
        }
    }
}

int[,,] newArray = new int[5, 4, 3];
int minRange = 10;
int maxRange = 100;
if (newArray.GetLength(0) * newArray.GetLength(1) * newArray.GetLength(2) > minRange + maxRange) // для положительного диапазона
    Console.WriteLine("Размер диапазона не позволяет заполнить массив неповторяющимися элементами!");
else
{
    FillArray3D(newArray, minRange, maxRange);
    PrintArray3D(newArray);
    IndexsElementsArray3D(newArray);
}