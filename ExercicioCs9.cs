using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Código de Produto");
        Console.Write("Digite o Código do Produto: ");
        int codigo = int.Parse(Console.ReadLine());
        if (codigo > 0 && codigo < 11)
        {
            Console.WriteLine($"o Código {codigo} corresponde a um Alimento Não Perecível");
        }
        else if (codigo > 10 && codigo < 21)
        {
            Console.WriteLine($"o Código {codigo} corresponde a um Alimento Perecível");
        }
        else if (codigo > 20 && codigo < 31)
        {
            Console.WriteLine($"o Código {codigo} corresponde a um Vestuário");
        }
        else if (codigo > 30 && codigo < 41)
        {
            Console.WriteLine($"o Código {codigo} corresponde a um Eletrônico");
        }
        else
        {
            Console.WriteLine($" o Código {codigo} é Inválido");
        }
    }
}