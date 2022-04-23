// Напишите функцию, которая принимает на вход число и выдаёт сумму цифр в числе

int Sum(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    if (sum < 0)
        sum = -sum;
    return sum;
}

System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр в числе {number} = {Sum(number)}.");