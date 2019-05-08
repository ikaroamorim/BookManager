using BookManager.Models;
using System;
using System.Collections.Generic;
using static System.Console;
using static System.DateTime;

namespace BookManager
{
  class Program
  {
    static bool done;
    static List<Livro> Livros = new List<Livro>();
    static void Main(string[] args)
    {
      Console.WriteLine($"Bookmanag Inciado às {Now.ToShortDateString()}");
      while (!done)
        ShowMenu();
    }
    private static void ShowMenu()
    {
      Console.WriteLine("Escolha uma das opções abaixo:");
      Console.WriteLine("1. Adicionar um novo livro");
      Console.WriteLine("2. Listar livros cadastrados");
      Console.WriteLine("3. Remover um livro");
      Console.WriteLine("S. Sair");

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
        case string o when o == "s" || o == "S":
          done = true;
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
      for (int i = 0; i < Livros.Count; i++)
      {
        var livro = Livros[i];
      }
      foreach (var livro in Livros)
      {
        WriteLine(livro.Nome);

      }
      
    }

    private static void AdicionarNovoLivro()
    {
      Console.WriteLine("Digite o nome do livro");
      var nome = ReadLine();

      Console.WriteLine("Digite o nome do descrição");
      var descricao = ReadLine();

      Console.WriteLine("Digite a editora do livro");
      var editora = ReadLine();

      Console.WriteLine("Digite o ano do livro");
      int ano;
      while(!int.TryParse(ReadLine(), out ano))
        WriteLine("Ano inválido digite novamente");

      Console.WriteLine("Digite a data de lcmto do livro (fomato dd/mm/aaaa");
      DateTime dataLancamento;
      while (!DateTime.TryParse(ReadLine(), out dataLancamento))
        WriteLine("Data lcmto inválido digite novamente");

      Console.WriteLine("Digite a largura do livro (cm)");
      float largura;
      while (!float.TryParse(ReadLine(), out largura))
        WriteLine("Largura inválido digite novamente");

      Console.WriteLine("Digite a altura do livro (cm)");
      float altura;
      while (!float.TryParse(ReadLine(), out altura))
        WriteLine("Altura inválido digite novamente");

      Console.WriteLine("Digite a profundidade do livro (cm)");
      float profundidade;
      while (!float.TryParse(ReadLine(), out profundidade))
        WriteLine("Profundidade inválido digite novamente");

      var livro = new Livro(nome)
      {
        Descricao = descricao,
        Editora = editora,
        Ano = ano,
        DataLancamento = dataLancamento,
        Altura = altura,
        Largura = largura,
        Profundidade = profundidade
      };

      Livros.Add(livro);

    }
  }
}
