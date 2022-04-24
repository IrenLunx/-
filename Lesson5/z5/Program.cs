// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

void Random(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-200, 200);
    }
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

void Multiply(int[] array)
{
    int n1 = array.Length;
    int[] array2 = new int[array.Length / 2 + array.Length % 2];
    int n2 = array2.Length;
    for (int i = 0; i <= n1 / 2; i++)
    {
        array2[i] = array[i] * array[^(i + 1)];
    }
    if (n2 % 2 != 0)
        array2[n2 - 1] = array[n1 / 2];
    Print(array2);
}

int[] number = new int[9];
Random(number);
Print(number);
Multiply(number);
