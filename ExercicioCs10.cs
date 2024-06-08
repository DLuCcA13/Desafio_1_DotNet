using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Operações entre dois números");
        Console.WriteLine("Digite o primeiro número: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        double n2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o símbolo da operação desejada: ");
        string simbolo = Console.ReadLine();
        double resultado = 0;

        if (simbolo == "+")
        {
            resultado = n1 + n2;
            Console.Write($"o resultado da soma entre {n1} + {n2} foi de {resultado}");
        }
        else if (simbolo == "-")
        {
            resultado = n1 - n2;
            Console.Write($"o resultado da subtração entre {n1} - {n2} foi de {resultado}");
        }
        else if (simbolo == "*")
        {
            resultado = n1 * n2;
            Console.Write($"o resultado da multiplicação entre {n1} * {n2} foi de {resultado}");
        }
        else if (simbolo == "/")
        {
            resultado = n1 / n2;
            Console.Write($"o resultado da divisão entre {n1} / {n2} foi de {resultado}");
        }
        else
        {
            Console.Write("Operação inválida");
        }
    }
}