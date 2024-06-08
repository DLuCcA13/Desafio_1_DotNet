using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ano Bissexto");
        Console.Write("Digite o ano: ");
        int ano = int.Parse(Console.ReadLine());
        if(ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0){
          Console.Write($"O ano {ano} é bissexto");
        } else{
          Console.Write($"O ano {ano} não é bissexto");
        }
    }
}