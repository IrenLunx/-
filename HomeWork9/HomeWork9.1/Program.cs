// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. 453 -> 12. 45 -> 9

int SumNumeralsNumber(int number)
{
    return number == 0 ? 0 : number % 10 + SumNumeralsNumber(number / 10);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {number} = {SumNumeralsNumber(number)}");