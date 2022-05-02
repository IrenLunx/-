// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь

System.Console.WriteLine("Введите несколько чисел через пробел: ");
string write = Console.ReadLine();

int Read(string number)
{
    string[] massString = number.Split();
    int[] mass = new int[massString.Length];
    int result = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = Convert.ToInt32(massString[i]);
        if (mass[i] > 0)
            result += 1;
    }
    return result;
}

System.Console.WriteLine(Read(write));