// Возведите число А в натуральную степень B используя цикл

int Function(int a, int b)
{
    int count = 0;
    int pow = 1;
    while(count<b)
    {
        pow = pow * a;   //Math.Pow(a,count);
        count++;
    }
    return pow;
}

Console.WriteLine("Введите число A:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите число B:");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine();

Function(number1,number2);
Console.WriteLine($"{number1}^{number2} = {Function(number1,number2)};");