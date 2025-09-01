using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Exercicios;

public class LivroFotos
{
    protected int numeroPaginas;
    public LivroFotos()
    {
        numeroPaginas = 16;
    }
    public LivroFotos(int numeroPaginas)
    {
        this.numeroPaginas = numeroPaginas;
    }
    public int GetNumeroPaginas()
    {
        return numeroPaginas;
    }
}