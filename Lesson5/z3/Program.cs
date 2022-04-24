// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

void Random(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-200, 200);

    }
}

void Find(int[] arr, int a)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == a)
        {
            System.Console.WriteLine("Да, индекс: " + i);
            return;
        }
    }
    System.Console.WriteLine("Нет совпадений");
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

int[] arr = new int[5];
Random(arr);
Print(arr);
int x = Convert.ToInt32(Console.ReadLine());
Find(arr, x);