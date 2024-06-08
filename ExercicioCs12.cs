using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Maior que 100");
        Console.Write("Digite um número:");
        int n = int.Parse(Console.ReadLine());
        int dobro;
        if (n < 100)
        {
            dobro = n * 2;
            Console.Write($"o numero {n} é menor que 100, logo seu dobro é {dobro}");
        } else {
          Console.Write($"o numero {n} é maior que 100");
        }
    }
}