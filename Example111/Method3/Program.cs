// Не принимают, но возвращают

int Method()
{
    return DateTime.Now.Year;
}

int year = Method();
System.Console.WriteLine(year);