
Console.WriteLine("Введите число факториала: ");
int n = int.Parse(Console.ReadLine());
int size = n;
int f = 1;
while (n > 1)
{
    f *= n;
    n--;
}
Console.WriteLine($"Факториал {size} = {f}");