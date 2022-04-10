//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int numberA = 20, numberB = 100, numberC = 10000, max = numberA;

if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
Console.WriteLine($"Максимальное число: {max}!");