// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];
int sumPozitive = 0;
int sumNegative = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " ");
    if(array[i] >= 0) sumPozitive = sumPozitive + array[i];
    else sumNegative =  sumNegative + array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива: {sumPozitive}");
Console.WriteLine($"Сумма отрицательных элементов массива: {sumNegative}");