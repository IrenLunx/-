// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int numberA = 9, numberB = 8;

if (numberA > numberB) 
{
    Console.WriteLine($"Максимальное число: {numberA}, минимальное число: {numberB}.");
}
if (numberB > numberA)
{
    Console.WriteLine($"Максимальное число: {numberB}, минимальное число: {numberA}.");
}
if (numberA == numberB)
{
    Console.WriteLine("Числа равны.");
}