// Программа, которая будет преобразовывать десятичное число в двоичное

string Do(int number)
{
    string ost = String.Empty;
    while (number > 0)
    {
        int result = number % 2;
        ost = result.ToString() + ost; // можно без To.String, главное - порядок
        number /= 2;
    }
    return ost;
}

void Do2(int number)
{
    string ost = String.Empty;
    while (number > 0)
    {
        int result = number % 2;
        ost += result;
        number /= 2;
    }
    for (int i = 0; i < ost.Length; i++)
        System.Console.Write(ost[^(i + 1)]);
}

int number = 2;
Do2(number);