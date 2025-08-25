using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Exemplos_HerancaAgregacaoComposicao;

public class LivroFisico : Livro
{
    public int NumeroPaginas { get; set; }

    public LivroFisico(string titulo, string nomeAutor, int numeroPaginas)
        : base(titulo, nomeAutor)
    {
        NumeroPaginas = numeroPaginas;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Livro Físico: {Titulo} ({NumeroPaginas} páginas - Autor: {autor.Nome})");
    }
}
