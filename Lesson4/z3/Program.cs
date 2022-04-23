// На вход число (А) и выдают произведение чисел от 1 до А 

int Factorial(int A)
{
    int result = 1;
    for (int i = 1; i <= A; i++)
    {
        result *= i;
    }
    return result;
}

System.Console.WriteLine(Factorial(-1));