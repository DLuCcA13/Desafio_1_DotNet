using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Maior ou Menor");
    Console.WriteLine("Digite um número: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro número: ");
    int n2 = int.Parse(Console.ReadLine());

    if(n1 == n2){
      Console.WriteLine($"Os números {n1} e {n2} são iguais.");
    }else{
      if(n1 < n2){
        Console.WriteLine($"O número {n1} é menor que {n2}.");
      }else{
        Console.WriteLine($"O número {n1} é maior que {n2}.");
      }
    }
  }
}