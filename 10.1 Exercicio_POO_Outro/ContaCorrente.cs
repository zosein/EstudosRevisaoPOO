using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_Exercicio_POO_Outro
{
    //conta corrente - implementada com permissão de saldo negativo
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(string numero, string nomeCliente) : base(numero, nomeCliente)
        { }

        public override bool Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor do saque deve ser maior que 0.");
                return false;
            }

            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso.");
            return true;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n--- Conta Corrente ---");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Cliente: {NomeCliente}");
            Console.WriteLine($"Tipo: Conta Corrente");
            ExibirSaldo();
        }
    }
}
