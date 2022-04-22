int Square(int number) // Вывести квадрат числа. Четвертый метод
{
    number = number * number;
    return number;
}

// int num = Square(7);
// System.Console.WriteLine(num);

void SquareTwo(int num1, int num2) // По двум заданным числам выводить является ли одно квадратом другого. Второй метод
{
    if (num1 == num2 * num2)
        System.Console.WriteLine($"Число {num1} является квадратом {num2}.");
    else
        System.Console.WriteLine($"Число {num1} не является квадратом {num2}.");
}

// int number = 26, num = 5;
// SquareTwo(number, num);

void MinMax(string num1, string num2) // Даны 2 числа. Показать большее и меньшее число. Второй метод
{
    int i = int.Parse(num1);
    int c = int.Parse(num2);
    if (i < c)
        System.Console.WriteLine($"Большее число - {num2}, меньшее число - {num1}.");
    else
        System.Console.WriteLine($"Большее число - {num1}, меньшее число - {num2}.");
}

// System.Console.WriteLine("Введите число 1: ");
// string num1 = Console.ReadLine();
// System.Console.WriteLine("Введите число 2: ");
// string num2 = Console.ReadLine();
// MinMax(num1, num2);

int Day(int number) // По заданому номеру вывести какой это день недели
{
    if (number == 1)
        System.Console.WriteLine($"{number} день - это понедельник!");
    if (number == 2)
        System.Console.WriteLine($"{number} день - это вторник!");
    if (number == 3)
        System.Console.WriteLine($"{number} день - это среда!");
    if (number == 4)
        System.Console.WriteLine($"{number} день - это четверг!");
    if (number == 5)
        System.Console.WriteLine($"{number} день - это пятница!");
    if (number == 6)
        System.Console.WriteLine($"{number} день - это суббота!");
    if (number == 7)
        System.Console.WriteLine($"{number} день - это воскресенье!");
    if (number < 1 || number > 7)
        System.Console.WriteLine($"{number} день не является днем недели!");
    return number;
}

// int number = new Random().Next(-1, 10);
// System.Console.WriteLine("Наше число - " + number);
// Day(number);

void MaxThree(int[] array) // Максимальное из 3 чисел
{
    int max = array[0];
    if (max < array[1])
        max = array[1];
    if (max < array[2])
        max = array[2];
    System.Console.WriteLine(max);
}

// int[] number = {10, 7, 6};
// MaxThree(number);
