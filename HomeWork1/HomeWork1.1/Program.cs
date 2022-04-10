// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int numberA = 7, numberB = 7;

if (numberA > numberB)
{
    Console.WriteLine($"Максимальное число: {numberA}, минимальное число: {numberB}.");
}
else
{
    Console.WriteLine($"Максимальное число: {numberB}, минимальное число: {numberA}.");
}
if (numberA == numberB)
{
    Console.WriteLine("Числа равны.");
}