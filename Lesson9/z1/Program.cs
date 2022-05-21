// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

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

int n = 5;
int i = 1;
PrintToNumber(i, n);

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

void PrintNums(int maxNum, int currentNum = 1)
{
    if(currentNum <= maxNum)
    {
        string symbol = ", ";
        if(currentNum == maxNum)
        {
            symbol = ".";
        }
        Console.Write(currentNum + symbol);
        currentNum++;
        PrintNums(maxNum, currentNum);
    }
}

PrintNums(m);