int[] array = new int[] {1, 7, 3, 6, 10, 0, 9, 50, 15};
int size = 9;
for (int j = 0; j < size - 1; j++)
{
    for (int i = 0; i < size - 1; i++)
    {
        if (array[i] > array[i + 1])
        {
            int help = array[i];
            array[i] = array[i + 1];
            array[i + 1] = help;
        }
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}

PrintArray(array);