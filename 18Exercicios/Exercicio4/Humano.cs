using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Exercicios.Exercicio4;

public class Humano
{
    public string? Nome { get; set; }

    public Humano(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Olá, meu nome é {Nome}";
    }
}
