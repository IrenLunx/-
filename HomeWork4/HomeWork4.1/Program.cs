// Напишите (функцию) цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int NaturalDegree(int numberA, int numberB)
{
    int multiply = numberA;
    for (int i = 2; i <= numberB; i++)
    {
        multiply *= numberA; 
    }
    return multiply;
}

int Binpow(int a, int n) // log2(n) бинарное возведение в степень
{
  int result = 1;
  while (n != 0)
  {
    if (n % 2 == 1)
      result *= a;
    a *= a;
    n /= 2;
  }
  return result;
}

System.Console.Write("Введите число, которое нужно возвести в степень: ");
int number1 = int.Parse(Console.ReadLine());
System.Console.Write("Степень: ");
int number2 = int.Parse(Console.ReadLine());
System.Console.WriteLine($"{number1} в {number2} степени = {NaturalDegree(number1, number2)}.");