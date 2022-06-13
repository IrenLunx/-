// Напишите программу, которая на вход принимает два числа и выдает первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих

void SumNumbers(int n, int m, int count)
{
    if (count == 0) return;
    Console.Write(n + " ");
    SumNumbers(m, m + n, count - 1);
}

Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());
Console.Write("Введите количество чисел в выводе: ");
int n = int.Parse(Console.ReadLine());
SumNumbers(numberOne, numberTwo, n);