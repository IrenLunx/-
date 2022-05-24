// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumeralsNumber(int m, int n)
{
    if (m > n) return 0;
    return m + SumNumeralsNumber(m + 1, n);
}

int m = 1;
int n = 15;
System.Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {SumNumeralsNumber(m, n)}");