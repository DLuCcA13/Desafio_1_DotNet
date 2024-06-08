using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Sistema de Par ou Impar");
        Console.Write("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num == 0)
        {
            Console.WriteLine($"o número {num} é Zero");
        }
        else
        {
            int resto = num % 2;
            if (resto == 0)
            {
                Console.WriteLine($"o numero {num} é Ppar");
            }
            else
            {
                Console.WriteLine($"o numero {num} é Impar");
            }
        }
    }
}