using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Exercicios_POO_Heranca
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        public string? TitularConta { get; set; }
        public decimal SaldoConta { get; set; } = 0.00m;

        public virtual double Juros { get; set; } = 0.00;

        private decimal CalculaRendimento(double juros)
        {
            return SaldoConta * (decimal)Juros;
        }

        public virtual decimal Sacar(decimal valor)
        {
            SaldoConta -= valor;
            return SaldoConta;
        }

        public decimal Depositar(decimal valor)
        {
            SaldoConta += valor;
            SaldoConta = SaldoConta + CalculaRendimento(Juros);
            return SaldoConta;
        }
    }
}
