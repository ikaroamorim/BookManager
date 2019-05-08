using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Models
{
  public class Livro
  {
    public string Nome { get; set; } // = "C#"; 
    public string Descricao { get; set; }
    public string Editora { get; set; }
    public int Ano { get; set; }
    public DateTime DataLancamento { get; set; }
    public float Largura { get; set; }
    public float Altura { get; set; }
    public float Profundidade { get; set; }
    public string Dimensoes { get => $"{Largura} x {Altura} x {Profundidade} cm"; }


    public Livro(string nome)
    {
      Nome = nome;
    }
  }
}
