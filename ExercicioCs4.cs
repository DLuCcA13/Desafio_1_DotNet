using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine (" Area do Triângulo");
    Console.WriteLine("Informe o valor do lado A do triângulo:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o valor do lado B do triângulo:");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o valor do lado C do triângulo:");
    int c = int.Parse(Console.ReadLine());
    if((a + b > c) && (a + c > b) && (b + c > a)){
      Console.WriteLine("É um triângulo");
    }else{
      Console.WriteLine("Não é um triângulo");
    }
  }
}