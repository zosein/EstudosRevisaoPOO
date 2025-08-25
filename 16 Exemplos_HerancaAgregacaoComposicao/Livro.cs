using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Exemplos_HerancaAgregacaoComposicao;

public abstract class Livro
{
    public string? Titulo { get; set; }
    protected Autor autor;

    public Livro(string? titulo, string nomeAutor)
    {
        this.Titulo = titulo;
        this.autor = new Autor(nomeAutor); //composição: Autor nasce com o Livro
    }

    public abstract void ExibirInfo();
}
