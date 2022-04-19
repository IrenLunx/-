Console.WriteLine("Введите номер четверти: ");

string num1 = Console.ReadLine();
int num = Convert.ToInt32(num1);

if (num == 1)
    Console.WriteLine("х и у положительные");
if (num == 2)
    Console.WriteLine("х отрицательные и у положительные");
if (num == 3)
    Console.WriteLine("х и у отрицательные");
if (num == 4)
    Console.WriteLine("х положительные и у отрицательные");