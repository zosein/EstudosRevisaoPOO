using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Exercicios_POO_Heranca
{
    public class ContaPoupanca : ContaCorrente
    {
        public override double Juros { get; set; } = 0.005;

        public override decimal Sacar(decimal valor)
        {
            if (SaldoConta >= valor)
            {
                SaldoConta -= valor;
                return SaldoConta;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
                return SaldoConta;
            }
        }
    }
}
