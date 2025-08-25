using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Polimorfismo;

public class Circulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando com a classe derivada Circulo...");
    }
}
