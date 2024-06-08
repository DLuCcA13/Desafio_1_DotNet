using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Categoria");
        Console.Write("Digite o numero da sua categoria: ");
        int categoria = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor da compra: ");
        double valor = double.Parse(Console.ReadLine());
        double desconto = 0;

        if (categoria == 1)
        {
            Console.WriteLine($"Sua Categoria é 'Comum', logo não tem desconto");
            Console.Write($"Valor da sua compra foi de R${valor}");
        }
        else if (categoria == 2)
        {
            desconto = valor * 0.1;
            Console.WriteLine($"Sua Categoria é 'Associado', logo tem 10% de desconto");
            Console.Write($"Valor da sua compra foi de R${valor}, com o descoto de R${desconto}, totalizando R${valor - desconto}");
        }
        else if (categoria == 3)
        {
            desconto = valor * 0.2;
            Console.WriteLine($"Sua Categoria é 'VIP', logo tem 20% de desconto");
            Console.Write($"Valor da sua compra foi de R${valor}, com o descoto de R${desconto}, totalizando R${valor - desconto}");
        }
        else
        {
            Console.WriteLine("Categoria invalida");
        }

    }
}