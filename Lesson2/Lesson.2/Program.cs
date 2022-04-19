int number = new Random().Next(10, 100);
Console.WriteLine(number + "- рандомное число");

if (number / 10 < number % 10)
    Console.WriteLine($"Максимальное число {number % 10}!");
else
    Console.WriteLine($"Максимальное число {number / 10}!");