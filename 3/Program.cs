// Подсчитать сумму цифр в числе

int Sum(int N)
{
   int result = 0;
   while (N != 0)
    {
        result = result + N % 10;
        N = N / 10;
    }
    return result;
}

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Sum(n);
Console.WriteLine($"Сумма цифр в числе n равно {Sum(n)}");


// Предыдущая функция:
// void Function(int N, int a1, int a2, int a3)

// {
//     if (N>=100 && N<=999)
//     {
//         a1 = N/100;
//         a2 = N%100/10;
//         a3 = N%10;
//         Console.WriteLine($" {a1} + {a2} + {a3} = {a1+a2+a3}");
//     }
// }