// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] Input()
{
    System.Console.Write("Введите вещественные числа: ");
    string[] strNums =  Console.ReadLine().Split();
    double[] arr = new double[strNums.Length];

    for (int i = 0; i < strNums.Length; i++)
    {
        arr[i] = double.Parse(strNums[i].Replace('.', ','));
    }
    return arr;
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

double Difference(double[] array)
{
    double dif = 0;
    dif = Max(array) - Min(array);
    return dif;
}

double[] array = Input();
System.Console.WriteLine("Разница между максимальным и минимальным числами: " + Difference(array));