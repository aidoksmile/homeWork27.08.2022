// Подсчитать сумму цифр в числе

void Function(int N, int a1, int a2, int a3)

{
    if (N>=100 && N<=999)
    {
        a1 = N/100;
        a2 = N%100/10;
        a3 = N%10;
        Console.WriteLine($" {a1} + {a2} + {a3} = {a1+a2+a3}");
    }
}
Console.WriteLine("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine());
int number1 = 0;
int number2 = 0 ;
int number3 = 0;
Function(n, number1, number2, number3);