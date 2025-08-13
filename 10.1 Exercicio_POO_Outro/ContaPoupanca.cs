using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_Exercicio_POO_Outro
{
    //conta poupança - permite saldo negativo e tem rendimentos de 0,5%
    public class ContaPoupanca : ContaBancaria
    {
        private const decimal TaxaJuros = 0.005m;

        public ContaPoupanca(string numero, string nomeCliente) : base(numero, nomeCliente)
        { }

        //sobrescreve o metodo de deposito p/ aplicar rendimentos
        public override void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor do depósito deve ser maior que 0.");

            decimal rendimento = valor * TaxaJuros;
            Saldo += valor + rendimento;

            Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso.");
            Console.WriteLine($"Rendimento aplicado: R$ {rendimento:F2} (0,5%)");
            Console.WriteLine($"Valor total creditado: R$ {(valor + rendimento):F2}");
        }

        //Saque não permite saldo negativo, usa implementacao da classe base

        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n--- Conta Poupança ---");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Cliente: {NomeCliente}");
            Console.WriteLine($"Tipo: Conta Poupança");
            Console.WriteLine($"Taxa de juros: {TaxaJuros * 100:F1}% por depósito");
            ExibirSaldo();
        }
    }
}
