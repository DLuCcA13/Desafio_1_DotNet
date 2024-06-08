using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Sistema de Negativo e Positivo");
    Console.WriteLine("Digite um número: ");
    int n = int.Parse(Console.ReadLine());
    if(n == 0){
      Console.WriteLine($"O número {n} é neutro");
    }else{
      if(n < 0){
        Console.WriteLine($"O número {n} é negativo");
      } else{
        Console.WriteLine($"O número {n} é positivo");
      }
    }
  }
}