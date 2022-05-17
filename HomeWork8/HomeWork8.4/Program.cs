// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

int CheckSpecialNumber(int[,,] array, int minValue, int maxValue, int number)
{
    int result = number;
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                if (array[a, b, c] == number)
                    CheckSpecialNumber(array, minValue, maxValue);
            }
        }
    }
    return number;
}

void CheckSpecialArray(int[,,] array, int minValue, int maxValue)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                CheckSpecialNumber(array, minValue, maxValue, );
            }
        }
    }
}

void FillArray3D(int[,,] array, int minValue, int maxValue)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                array[a, b, c] = new Random().Next(minValue, maxValue);
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
int minRange = 1;
int maxRange = 10;
if (minRange < 0) minRange = -minRange;
if (maxRange < 0) maxRange = -maxRange;
int sumRange = minRange + maxRange;

if (newArray.GetLength(0) * newArray.GetLength(1) * newArray.GetLength(2) > sumRange)
    Console.WriteLine("Размер массива не позволяет заполнить его неповторяющимися элементами!");
else
{
    FillArray3D(newArray, minRange, maxRange);
    PrintArray3D(newArray);
    IndexsElementsArray3D(newArray);
}