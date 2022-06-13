// Массив одномерный, автоматически заполненный целых чисел
// нужно сформировать новый массив из квадратов чисел исходного массива
// функция для вывода только!!!


/* string TruePrint(int[] array)
{
    string res = string.Empty;
    int size = array.Length;
    res = "[ ";
    for (int i = 0; i < size; i++)
    {
        res += $"{array[i], 3}";
    }
    res = " ]";
    return res;
}
*/

string TruePrint(int[] array)
{
   return $"[ {string.Join(' ', array)} ]";
}

