// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

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

void CheckingAndSum (int [] array)
{
    int sumPozitive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 0) sumPozitive = sumPozitive + array[i];
        else sumNegative =  sumNegative + array[i];
    }
    Console.WriteLine($"Сумма положительных элементов массива: {sumPozitive}");
    Console.WriteLine($"Сумма отрицательных элементов массива: {sumNegative}");
}

int LengthArray = 12;
int[] array = new int[LengthArray];
RandomArrayElement(array, 0, 10);
PrintArray(array);
CheckingAndSum (array);










// int[] array = new int[12];
// int sumPozitive = 0;
// int sumNegative = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 10);
//     Console.Write(array[i] + " ");
//     if(array[i] >= 0) sumPozitive = sumPozitive + array[i];
//     else sumNegative =  sumNegative + array[i];
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма положительных элементов массива: {sumPozitive}");
// Console.WriteLine($"Сумма отрицательных элементов массива: {sumNegative}");