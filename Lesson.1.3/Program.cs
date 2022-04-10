Console.WriteLine("Введите число от 1 до 7: ");

string day = Console.ReadLine();

if (day != "1" && day != "2" && day != "3" && day != "4" && day != "5" && day != "6" && day != "7")
{
    Console.WriteLine("Нет такого дня недели!");
}
if (day == "1")
{
    Console.WriteLine("Понедельник");
}
if (day == "2")
{
    Console.WriteLine("Вторник");
}
if (day == "3")
{
    Console.WriteLine("Среда");
}
if (day == "4")
{
    Console.WriteLine("Четверг");
}
if (day == "5")
{
    Console.WriteLine("Пятница");
}
if (day == "6")
{
    Console.WriteLine("Суббота");
}
if (day == "7")
{
    Console.WriteLine("Воскресенье");
}