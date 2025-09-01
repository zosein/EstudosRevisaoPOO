using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Exercicios.Exercicio3;

public class Professor : Pessoa
{
    public Professor(string nome) : base(nome)
    { }

    public void Explicar()
    {
        Console.WriteLine($"{Nome} está explicando");
    }
}
