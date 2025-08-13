using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_Exercicio_POO_Outro
{
    //Classe base abstrata que define a base do comportamento de uma conta
    public abstract class ContaBancaria
    {
        //encapsulamento: propriedade com private, acesso controlado
        private decimal saldo;
        //propridades publicas somente leitura
        public string? Numero {  get; set; }
        public string? NomeCliente { get; set; }

        //propriedade protegida para acesso do saldo pelas classes filhas
        protected decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //construtor protegido, inicializa dados bancarios
        protected ContaBancaria(string numero, string nomeCliente)
        {
            Numero = numero ?? throw new ArgumentNullException(nameof(numero));
            NomeCliente = nomeCliente ?? throw new ArgumentNullException(nameof(nomeCliente));
            saldo = 0;
        }

        //método virtual que permite sobrescrita nas classes filhas/derivadas
        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor de deposito deve ser maior que 0.");
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizadpo com sucesso.");
        }

        public virtual bool Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor do saque deve ser maior que 0.");
                return false;
            }

            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso.");
                return true;
            }

            Console.WriteLine("Saldo insuficiente para realizar o saque.");
            return false;
        }

        //método que exibe saldo
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo:F2}");
        }

        //método abstrato para ser implementado pelas classes derivadas/filhas
        public abstract void ExibirInformacoes();

    }
}
