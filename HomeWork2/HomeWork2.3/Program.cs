// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = new Random().Next(1, 100000);
Console.Write("В числе " + number);

if (number < 100)
    System.Console.WriteLine(" третьего числа нет!");

while (number > 99)
{ 
    if (number < 1000)
    {
        Console.WriteLine(" третья цифра - " + (number % 10));
        break;
    }
    number = number / 10;
}