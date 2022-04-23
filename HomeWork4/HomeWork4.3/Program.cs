// Напишите программу, которая задаёт массив из некоторого количества элементов и выводит их на экран с помощью функций. 
// (можно спрашивать количество вводимых элементов и вводить все значения с клавиатуры)

void GenerateArray(int[] read)
{
    int index = 0;
    System.Console.Write("Введите числа: ");
    while (index < read.Length)
    {
        read[index] = int.Parse(Console.ReadLine());
        index++;
    }
}

void DisplayArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        System.Console.Write(array[index] + " ");
        index++;
    }
}

int[] array = new int[8];
GenerateArray(array);
DisplayArray(array);