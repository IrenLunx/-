// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100, 1000);
Console.WriteLine("Трехзначное число - " + number);

int resulte = number % 100 / 10;
Console.WriteLine("Его второе число - " + resulte);