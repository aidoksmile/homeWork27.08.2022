// Возведите число А в натуральную степень B используя цикл

void Function(int a, int b)
{
    int count = 1;
    double pow = 1;
    while(count<=b)
{
    pow = Math.Pow(a,count);
    count++;
    Console.WriteLine($"{a}^{count} = {pow};");
}
}
Console.WriteLine("Введите число A:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите число B:");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine();
Function(number1,number2);