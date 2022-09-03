// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] array = new int[8];
string FillArray(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]}  ";
    }
    return result;
}
Console.WriteLine(FillArray(array));