// Первые N числа Фибоначчи без использования рекурсии. 0 и 1 = 1. Пример: 7 чисел (0, 1, 1, 2, 3, 5, 8) 

void Fibonacci(int number)
{
    int one = 0, two = 1, three = 0;
    if (number <= 0)
        return;
    System.Console.Write("0 ");
    for (int i = 0; i < number-1; i++)
    {
        three = one + two;
        System.Console.Write(three + " ");
        two = one;
        one = three;
    }
}

int number = 7;
Fibonacci(number);