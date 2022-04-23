// Количество цифр в числе

int Quantity(int number)
{
    int result = 0;
    if (number == 0)
        return 1;
    while (number != 0)
    {
        number /= 10;
        result++;
    }
    return result;
}

System.Console.WriteLine(Quantity(0));
