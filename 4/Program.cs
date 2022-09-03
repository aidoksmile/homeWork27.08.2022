// Написать программу вычисления произведения чисел от 1 до N

void Multiplication (int n)
{
int count  = 1;
int result = 1;
while (count<=n)
{
result = result * count;
count++;
}
Console.WriteLine( $"{result}");
}
Console.WriteLine("Введите число N :");
int number  = int.Parse(Console.ReadLine());
Multiplication(number);