int numberA = new Random().Next(1, 11);
Console.WriteLine(numberA + "- первое число");
int numberB = new Random().Next(10, 101);
Console.WriteLine(numberB + "- второе число");

if (numberB % numberA == 0)
    Console.WriteLine($"число {numberB} кратно {numberA}");
else
    Console.WriteLine($"число {numberB} не кратно {numberA}, остаток: {numberB % numberA}");