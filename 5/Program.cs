// Показать кубы чисел, заканчивающихся на четную цифру

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
    Console.Write($"{element}, ");
    Console.WriteLine();
}

bool Checking(int num)
{
    bool result = false;
    if (num % 2 == 0) result = true;
    return result;
}

void Cube(int a)
{
    Console.WriteLine($"{Math.Pow(a, 3)}");
}

Console.Write("Введите количество чисел:");
int LengthArray = int.Parse(Console.ReadLine());
int[] array = new int[LengthArray];
int i = 1;

RandomArrayElement(array, 1, 8);
PrintArray(array);

foreach (int element in array)
{
    if (Checking(element) == true)
    {
        Console.Write($"{element}^3= ");
        Cube(element);
    }
    i++;
}