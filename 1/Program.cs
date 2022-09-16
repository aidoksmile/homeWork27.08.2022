// Найти кубы чисел от 1 до N

void Cube (int n)
{
int count  = 1;
    while (count<=n)
    {
                                                                    //double result = Math.Pow(count,3);
        Console.WriteLine($"{count}^3 = {count * count * count};");
        count++;
    }
}

Console.WriteLine("Введите число N :");
int number  = int.Parse(Console.ReadLine());
Cube(number);