// Написать программу вычисления произведения чисел от 1 до N

int Multiplication (int n)
{
    int count  = 1;
    int result = 1;
    while (count<=n)
    {
        result = result * count;
        count++;
    }
    return result;
}

Console.WriteLine("Введите число N :");
int number  = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {number} = {Multiplication(number)}");