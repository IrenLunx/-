// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = new Random().Next(-1000000, 1000000);
Console.Write("В числе " + number);

if (number < 0)
    number = -number;

if (number < 10 && number >= 0)
    System.Console.WriteLine(" нет третьего числа, потому что число однозначное!");

if (number < 100 && number >= 10)
    System.Console.WriteLine(" нет третьего числа, потому что число двузначное!");

while (number > 99)
{ 
    if (number < 1000)
    {
        Console.WriteLine(" третья цифра - " + (number % 10));
        break;
    }
    number = number / 10;
}