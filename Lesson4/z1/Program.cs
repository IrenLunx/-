// На вход число (А) и выдают сумму чисел от 1 до А 

int SumToA(int A)
{
    int result = 0;
    for (int i = 0; i <= A; i++)
    {
        result += i; // result = result + i. /= (деление). %= остаток от деления
    }
    return result;
}

// int sum = SumToA(4);
// System.Console.WriteLine(sum);
System.Console.WriteLine(SumToA(4));
System.Console.WriteLine(SumToA(6));
System.Console.WriteLine(SumToA(9));