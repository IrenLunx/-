// Напишите программу замены элементов массива: положительные замените на соответствующие отрицательные и наоборот.

void Random(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-200, 200);

    }
}

void Replace(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[] arr = new int[5];
Random(arr);
Print(arr);
Replace(arr);
Print(arr);