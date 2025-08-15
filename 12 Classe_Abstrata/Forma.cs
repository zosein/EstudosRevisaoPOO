using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Classe_Abstrata
{
    public abstract class Forma
    {
        public string? Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        //metodos abstratos
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

        //metodo comum
        public string Descricao()
        {
            return "Classe abstrata forma";
        }

    }
}
