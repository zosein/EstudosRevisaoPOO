using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Exemplos_HerancaAgregacaoComposicao;

public class Biblioteca
{
    public string? Nome { get; set; }
    private List<Livro> livros; //agregação: a biblio possui livros, mas podem existir fora dela

    public Biblioteca(string nome)
    {
        Nome = nome;
        livros = new List<Livro>();
    }

    public void AddLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void ExibirAcervo()
    {
        Console.WriteLine($"\nAcervo da Biblioteca {Nome}:");
        foreach(var livro in livros)
        {
            livro.ExibirInfo();
        }
    }
}
