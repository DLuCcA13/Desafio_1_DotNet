using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculo de IMC");
        Console.Write("Digite seu peso (Ex: 70):");
        double peso = double.Parse(Console.ReadLine());
        Console.Write("Digite sua altura (Metro Ex: 1.70):");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        if (imc < 18.5)
        {
            Console.Write($"Seu IMC é {imc:N2} e você está abaixo do peso");
        }
      else if (imc < 24.9)
        {
            Console.Write($"Seu IMC é {imc:N2} e você está com peso normal");
        }
      else if (imc < 29.99)
        {
            Console.Write($"Seu IMC é {imc:N2} e você está com sobrepeso");
        }
        else if (imc < 34.9)
        {
            Console.Write($"Seu IMC é {imc:N2} e você está com obesidade grau 1");
        }
        else if (imc < 39.9)
        {
            Console.Write($"Seu IMC é {imc:N2} e você está com obesidade grau 2");
        }
        else{
            Console.Write($"Seu IMC é {imc:N2} e você está com obesidade grau 3");

        }
    }
}