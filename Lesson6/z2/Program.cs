// Программа, которая принимает на вход три числа и проверяет, может ли существовать треугольник с такими сторонами

bool Triangle(int x, int y, int z)
{
    bool result = true;
    if (x < y + z && y < x + z && z < x + y)
        return result;
    else 
    {
        result = false;
        return result;
    }
}

System.Console.WriteLine(Triangle(100, 50, 1000));