// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void RandomArrayElement(int[] position, int min, int max)
{
    Random rand = new Random();
    int i = 0;
    while (i < position.Length)
    {
        position[i] = rand.Next(min, max);
        i++;
    }
}

void PrintArray(int[] position)
{
    foreach (int element in position)
    Console.Write($"{element} ");
    Console.WriteLine();
}

int LengthArray = 8;
int[] array = new int[LengthArray];
RandomArrayElement(array, 0, 2);
PrintArray(array);