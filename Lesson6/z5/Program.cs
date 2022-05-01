// Программа, которая будет создавать копию заданного массива с помощью поэлементного копирования

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
    }
    System.Console.WriteLine();
}

int[] NewArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int[] array = {5, 7, 9, 1, 8, 9};
PrintArray(array);
int[] newArray = NewArray(array);
PrintArray(newArray);