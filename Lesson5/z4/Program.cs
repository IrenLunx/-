// Задайте одномерный массив из 123 случайных чисел. Нвйдите количество двузначных элементов массива.

void Random(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-200, 200);
    }
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (Math.Abs(array[i]) > 9 && Math.Abs(array[i]) < 100)
            sum++;
    }
    return sum;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 10 == 0)
            System.Console.WriteLine();
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[] number = new int[123];
Random(number);
Print(number);
System.Console.WriteLine($"Количество двузначных чисел массива = {Sum(number)}");
