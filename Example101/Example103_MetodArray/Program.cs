int[] array = {68, 34, 564, 756, 34, 45, 67};

int n = array.Length;
int find = 34;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // Если несколько одинаковых чисел в массиве, а нам нужно только первое, то break - "остановка" как только условие выполнится
    }
    index++;
}