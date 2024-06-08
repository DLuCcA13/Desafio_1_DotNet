using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Média de notas");
        Console.WriteLine("Digite a nota 1");
        double n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 2");
        double n2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 3");
        double n3 = double.Parse(Console.ReadLine());
        double media = (n1 + n2 + n3) / 3;
        media = double.Round(media, 2);
      
        if (media > 6.99)
        {
            Console.WriteLine($"Sua média foi {media}, logo está Aprovado");
        }
        else if (media > 4.99)
        {
            Console.WriteLine($"Sua média foi {media}, logo está de Recuperação");
        }
        else
        {
            Console.WriteLine($"Sua média foi {media}, logo está Reprovado");
        }

    }
}