// Принимают, но не возвращают

// void Method(string str)
// {
//     System.Console.WriteLine(str);
// }
// Method(str: "Текст сообщения");

void Method(string str, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(str);
        i++;
    }
}
// Method("Текст", 4);
// Method(str: "Текст", count: 4);
Method(count: 4, str: "Текст");