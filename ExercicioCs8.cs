using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nota");
        Console.Write("Informe a nota: ");
        double nota = double.Parse(Console.ReadLine());
        nota = double.Round(nota, 2);
        if (nota < 3)
        {
            Console.Write($"o valor da nota foi de {nota} e o conceito foi F");
        }
        else if (nota < 5)
        {
            Console.Write($"o valor da nota foi de {nota} e o conceito foi D");
        }
        else if (nota < 7)
        {
            Console.Write($"o valor da nota foi de {nota} e o conceito foi C");
        }
        else if (nota < 9)
        {
            Console.Write($"o valor da nota foi de {nota} e o conceito foi B");
        }
        else
        {
            Console.Write($"o valor da nota foi de {nota} e o conceito foi A");
        }
}
}