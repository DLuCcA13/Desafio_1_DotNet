using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("intervalo entre 10 e 20");
    Console.WriteLine("Digite um número");
    double n = double.Parse(Console.ReadLine());
    n = double.Round(n, 2);
    if(n > 9.99 && n < 20.01){
      Console.WriteLine($"o numero {n} está entre 10 e 20");
    }else{
      Console.WriteLine($"o numero {n} não está entre 10 e 20");
    }
  }
}