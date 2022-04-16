int[] array1 = new int[100]; 
int index = 0;

while (index <= 99)
{
    array1[index] = new Random().Next(1, 10);
    index++;
}

index = 0;

while (index <= 99)
{
    if (index % 10 == 0)
        Console.WriteLine();
    Console.Write(array1[index] + " ");
    index++;
}