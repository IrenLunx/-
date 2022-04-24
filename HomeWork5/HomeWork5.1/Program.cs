// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void RandomPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int Plus(int[] array)
{
    int quantiti = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            quantiti++;
    }
    return quantiti;
}

int[] array = new int[10];
RandomPrint(array);
System.Console.WriteLine("Количество четных чисел в массиве: " + Plus(array));