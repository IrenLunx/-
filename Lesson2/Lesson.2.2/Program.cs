int number = new Random().Next(23, 1000);

if (number % 7 == 0 && number % 23 == 0)
    Console.WriteLine($"Число {number} делится одновременно на 7 и на 23.");
else
    Console.WriteLine($"Число {number} не делится одновременно на 7 и на 23.");