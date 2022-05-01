// Разворот одномерного массива

int[] array = new int[5] {1, 5, 7, 9, 10};

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

void Swap(int[] array, int i, int j) // решение двумя функциями
{
    int help = array[i];
    array[i] = array[j];
    array[j] = help;
}

void Reverse2(int[] array)
{
    for (int index = 0; index < array.Length / 2; index++)
    {
        Swap(array, index, array.Length-index-1);
    }
}

void Reverse(int[] array) // решение только этой функцией
{
    for (int index = 0; index < array.Length / 2; index++)
    {
        int help = array[index];
        array[index] = array[^(index + 1)]; // элементы с конца
        array[^(index + 1)] = help;
    }
}

int[] ReturnReverse(int[] array) // второе решение одной функцией
{
    int n = array.Length;
    int[] array2 = new int[n];
    for (int index = 0; index < n; index++)
    {
        array2[index] = array[^(index + 1)];
    }
    return array2;
}

PrintArray(array);
int[] newArray = ReturnReverse(array); // решение для последней функции
PrintArray(newArray);
// Array.Reverse(array); // встроенная функция
// PrintArray(array);