// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int n = new Random().Next(1, 100);
System.Console.WriteLine($"Наше число - {n}! Кубы чисел от 1 до {n}: ");
int i = 1;
int kub;

while (i < n)
{
    kub = i * i * i;
    if (i % 10 == 0)
        System.Console.WriteLine($"{kub}, ");
    else
        Console.Write($"{kub}, ");
    i++;
}
if (i == n)
{
    kub = i * i * i;
    Console.Write($"{kub}.");
}