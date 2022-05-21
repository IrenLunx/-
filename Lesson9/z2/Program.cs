// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void PrintToNumber(int currentNum, int maxVoid)
{
    if (currentNum <= maxVoid)
    {
        if (currentNum < maxVoid)
            Console.Write(currentNum + ", ");
        else
            Console.WriteLine(currentNum + " ");
        currentNum++;
        PrintToNumber(currentNum, maxVoid);
    }
}

int n = 10;
int m = 5;
PrintToNumber(m, n);