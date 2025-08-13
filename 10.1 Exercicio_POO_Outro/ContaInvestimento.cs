using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_Exercicio_POO_Outro
{
    public class ContaInvestimento : ContaBancaria
    {
        //conta investimento com taxa de juros no deposito e imposto no saque
        private const decimal TaxaInvestimento = 0.009m;
        private const decimal ImpostoSaque = 0.001m;

        public ContaInvestimento(string numero, string nomeCliente) : base(numero, nomeCliente)
        {
        }

        //sobrescreve deposito aplicando taxa de investimento
        public override void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor do depósito deve ser maior que 0");

            decimal rendimento = valor * TaxaInvestimento;
            Saldo += valor + rendimento;

            Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso.");
            Console.WriteLine($"Rendimento de investimentos: R$ {rendimento:F2} (0,9%)");
            Console.WriteLine($"Valor totl creditado: R$ {(valor + rendimento):F2}");
            
        }

        //sobrescreve metodo saque aplicando imposto
        public override bool Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"Valor do saque deve ser maior que 0.");
                return false;
            }

            decimal imposto = valor * ImpostoSaque;
            decimal valorTotalDebitado = valor + imposto;

            if (Saldo >= valorTotalDebitado)
            {
                Saldo -= valorTotalDebitado;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso.");
                Console.WriteLine($"Imposto cobrado: R$ {imposto:F2} (0,1%)");
                Console.WriteLine($"Valor total debitado: R$ {valorTotalDebitado:F2}");
                return true;
            }

            Console.WriteLine($"Valor insuficiente. Valor necessário: R$ {valorTotalDebitado:F2} (saque + imposto");
            return false;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n--- Conta de Investimento ---");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Cliente: {NomeCliente}");
            Console.WriteLine($"Tipo: Conta de Investimento");
            Console.WriteLine($"Taxa de Investimento: {TaxaInvestimento * 100:F1}% por depósito");
            Console.WriteLine($"Imposto sobre Saque: {ImpostoSaque * 100:F1}%");
            ExibirSaldo();
        }
    }
}
