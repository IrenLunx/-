// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int n = new Random().Next(2, 10);
System.Console.Write($"Наше число - {n}! Кубы чисел от 1 до {n}: ");
int i = 1;
int kub;

while (i < n)
{
    kub = i * i * i;
    Console.Write($"{kub}, ");
    i++;
}
if (i == n)
{
    kub = i * i * i;
    Console.Write($"{kub}.");
}