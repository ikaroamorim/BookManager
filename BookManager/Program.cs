using System;
using static System.Console;
using static System.DateTime;

namespace BookManager
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine($"Bookmanag Inciado às {Now.ToShortDateString()}");
      while (true)
        ShowMenu();
    }
    private static void ShowMenu()
    {
      Console.WriteLine("Escolha uma das opções abaixo:");
      Console.WriteLine("1. Adicionar um novo livro");
      Console.WriteLine("2. Listar livros cadastrados");
      Console.WriteLine("3. Remover um livro");
      string opcao = ReadLine();

      switch (opcao)
      {
        case "1":
          AdicionarNovoLivro();
          break;
        case "2":
          ListarLivros();
          break;
        case "3":
          RemoverLivros();
          break;
        default:
          Console.WriteLine("Opção Invalida");

          break;
      }
    }

    private static void RemoverLivros()
    {
      
    }

    private static void ListarLivros()
    {
      
    }

    private static void AdicionarNovoLivro()
    {
     
    }
  }
}
