// Вывод массива до 0

void PrintArrayToZero(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] == 0)
            break; // return;
        System.Console.Write(mas[i] + " ");   
    }
}

int[] array = {1, 5, 6 , 9, 0, 7, 5};
PrintArrayToZero(array);