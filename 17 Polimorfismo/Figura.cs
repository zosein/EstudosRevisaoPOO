using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Polimorfismo;

public class Figura
{
    public virtual void Desenhar()
    {
        Console.WriteLine("Desenhando com a classe base");
    }
}
