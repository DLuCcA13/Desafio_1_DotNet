using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Leitor de Idade");
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        if (idade < 0)
        {
            Console.WriteLine($"A idade não pode ser menor que 0");
        }
        else if (idade > 0 && idade < 13)
        {
            Console.WriteLine($"a idade {idade}, corresponde a uma Criança");
        }
        else if (idade < 18)
        {
            Console.WriteLine($"a idade {idade}, corresponde a um Adolescente");
        }
        else if (idade < 60)
        {
            Console.WriteLine($"a idade {idade}, corresponde a um Adulto");
        }
        else
        {
            Console.WriteLine($"a idade {idade}, corresponde a um Idoso");
        }
    }
}