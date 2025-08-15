using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_upcasting_downcasting
{
    class Circulo : Forma
    {
        public override void Desenhar()
            => Console.WriteLine("Desenhando circulo...");
        public void Zoom()
            => Console.WriteLine("Zoom...");
    }
}
