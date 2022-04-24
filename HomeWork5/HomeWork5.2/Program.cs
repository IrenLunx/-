// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void RandomPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum += array[i];
    }
    return sum;
}

int[] array = new int[10];
RandomPrint(array);
System.Console.WriteLine("Сумма элементов, стоящих в нечетных позициях: " + Sum(array));