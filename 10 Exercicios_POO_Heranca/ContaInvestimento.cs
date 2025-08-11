using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Exercicios_POO_Heranca
{
    public class ContaInvestimento : ContaCorrente  
    {
        public override double Juros { get; set; } = 0.009;
        public double Imposto { get; set; } = 0.001;

        private decimal CalculaImposto(double imposto)
        {
            return SaldoConta * (decimal)Imposto;
        }

        public override decimal Sacar(decimal valor)
        {
            if (SaldoConta >= valor)
            {
                SaldoConta -= valor - CalculaImposto(Imposto);
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
