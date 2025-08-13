using _10._1_Exercicio_POO_Outro;
using System;

Console.WriteLine("--- Sistema Banco ---\n");

try
{
    //contas desmostração
    ContaCorrente cc = new ContaCorrente("001", "Labubu da Silva");
    ContaPoupanca cp = new ContaPoupanca("010", "Maria Freitas");
    ContaInvestimento ci = new ContaInvestimento("301", "Caneta Azul");


    ContaBancaria[] contas = { cc, cp, ci };

    //operaçoes
    Console.WriteLine("--- Operações Bancarias ---\n");

    foreach (ContaBancaria conta in contas)
    {
        conta.ExibirInformacoes();
        Console.WriteLine();

        //teste depositos
        Console.WriteLine("Realizando deposito de R$ 1000,00: ");
        conta.Depositar(1000m);
        conta.ExibirSaldo();
        Console.WriteLine();

        //teste saque
        Console.WriteLine("Realizando saque de R$ 400,00: ");
        conta.Sacar(400);
        conta.ExibirSaldo();
        Console.WriteLine();

        //teste saque para gerar saque negativo
        Console.WriteLine("Realizando saque de R$ 700:");
        conta.Sacar(700);
        conta.ExibirSaldo();
        Console.WriteLine("\n" + new string('-', 50) + "\n");
    }

    //menu
    ExecutarMenu();
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();


static void ExecutarMenu()
{
    Console.WriteLine("--- Menu ---");
    Console.WriteLine("Criando conta corrente...");

    ContaCorrente contaTeste = new ContaCorrente("092", "Cliente teste");

    while (true)
    {
        Console.WriteLine("\nEscolha uma operação:");
        Console.WriteLine("1 - Depositar");
        Console.WriteLine("2 - Sacar");
        Console.WriteLine("3 - Exibir Saldo");
        Console.WriteLine("4 - Exibir Informações da Conta");
        Console.WriteLine("0 - Sair");
        Console.Write("Opção: ");

        string? opcao = Console.ReadLine();

        try
        {
            switch (opcao)
            {
                case "1":
                    Console.Write("Valor depósito: R$ ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal valorDeposito))
                    {
                        contaTeste.Depositar(valorDeposito);
                    }
                    else
                    {
                        Console.WriteLine("valor invalido");
                    }
                    break;

                case "2":
                    Console.Write("Valor saque: R$ ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal valorSaque))
                        contaTeste.Sacar(valorSaque);
                    else
                        Console.WriteLine("valor invalido");
                    break;
                case "3":
                    contaTeste.ExibirSaldo();
                    break;

                case "4":
                    contaTeste.ExibirInformacoes();
                    break;

                case "0":
                    Console.WriteLine("Saindo do menu interativo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;


            }
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Erro na operação: {ex.Message}");
        }
    }
}