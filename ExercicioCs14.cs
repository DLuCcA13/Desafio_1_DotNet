using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Negativo ou Positivo");
        Console.Write("Digite um número:");
        double n = double.Parse(Console.ReadLine());
        double kalc = 0;
        if (n < 0)
        {
            kalc = n * n;
            Console.WriteLine($"O número {n} é negativo e o resultado foi {kalc}");
        }
        else
        {
            kalc = Math.Sqrt(n);
            kalc = double.Round(kalc, 3);
            Console.WriteLine($"O número {n} é positivo e o resultado foi {kalc}");
        }
    }
}