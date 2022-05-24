// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int Akkerman(int m, int n)
{
    return m == 0 ? n + 1 : n == 0 ? Akkerman(m - 1, 1) : Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = 2;
int n = 3;
System.Console.WriteLine($"Функция Аккермана A({m}, {n}) = {Akkerman(m, n)}");