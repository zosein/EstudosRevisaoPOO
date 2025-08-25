using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Exemplos_HerancaAgregacaoComposicao;

public class Ebook : Livro
{
    public double TamanhoMB { get; set; }

    public Ebook(string titulo, string nomeAutor, double tamanhoMB)
        : base(titulo, nomeAutor)
    {
        TamanhoMB = tamanhoMB;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Ebook: {Titulo} ({TamanhoMB}MB) - Autor: {autor.Nome}");
    }
}
