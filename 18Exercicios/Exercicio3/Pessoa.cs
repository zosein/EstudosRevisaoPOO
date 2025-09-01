using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Exercicios.Exercicio3;

public class Pessoa
{
    protected string Nome {  get; set; }
    
    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}";
    }
}
