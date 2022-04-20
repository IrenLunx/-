// Принимают и возвращают. Цикд for. Задача: вывод таблицы умножения на экран


// string Method(int count, string text)
// {
//     int i = 0;
//     string result = ""; // string result = "";
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string str = Method(count: 10, text: "привет ");
// System.Console.WriteLine(str);

string Method(int count, string text)
{
    string result = ""; // string result = "";
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string str = Method(count: 10, text: "привет ");
// System.Console.WriteLine(str);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}"); // интерполяция строк
    }
    System.Console.WriteLine();
}
