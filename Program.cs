using System;
using System.Threading;
namespace guessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      int valorMinimo = 0;
      int valorMaximo = 101;
      const char maior = '>';
      const char menor = '<';
      const char igual = '=';
      char validador = ' ';
      int tentativa = 0;
      int operador = 0;
      int intera = 0;
      var random = new Random();
      System.Console.WriteLine($"Pense em um número de 1 à 100... Pensou?");
      Thread.Sleep(3000);
      System.Console.WriteLine($"Se for maior que {operador}, digite: '{maior}'\nSe for menor que {operador}, digite: '{menor}'\nSe for igual a {operador}, digite: '{igual}'\n  ");
      do
      {
        operador = random.Next(valorMinimo, valorMaximo);
        Console.WriteLine($" O número é: {operador}?");
        validador = char.Parse(Console.ReadLine());
        if (validador == igual)
        {
          System.Console.WriteLine($"I m the genius acertei seu número em {intera}");
          break;
        }

        if (validador == maior)
          valorMinimo = operador + 1;
        else if (validador == menor)
          valorMaximo = operador - 1;

        intera = intera + 1;
      } while (validador == igual || tentativa < 8);
      tentativa++;
    }
  }
}