// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void Random(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-9, 10);

    }
}

void Print(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        System.Console.Write(mas[i] + " ");
    }
    System.Console.WriteLine();
}

int SumPlus(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > 0)
            sum += mas[i];
    }
    return sum;
}

int SumMinus(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] < 0)
            sum += mas[i];
    }
    return sum;
}

int[] array = new int[12];
Random(array);
Print(array);
System.Console.WriteLine($"Сумма положительных чисел = {SumPlus(array)}");
System.Console.WriteLine($"Сумма отрицательных чисел = {SumMinus(array)}");
