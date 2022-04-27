// Двумерные или многомерные массивы

// string[,] table = new string[2, 5];

// String.Empty
// table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]

// table[1, 2] = "слово";

// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         System.Console.WriteLine($"-{table[i, j]}-");
//     }
// }

void PrintArray(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            System.Console.Write($"{num[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            num[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] number = new int[3, 4];

PrintArray(number);
FillArray(number);
System.Console.WriteLine();
PrintArray(number);
