using _17_Polimorfismo;


//Em C# Existem dois tipos de polimorfismo:
//1 - Polimorfismo em tempo de compilação (Sobrecarga de métodos e Operadores)
//==> Utiliza a sobrecarga de métodos e operadores para permitir que múltiplos métodos ou operadores tenham o mesmo nome, mas comportamentos diferentes com base nos parâmetros fornecidos.
//2 - Polimorfismo em tempo de execução (Herança e Interfaces)
//==> Permite que uma classe derivada substitua métodos da classe base, possibilitando que o comportamento do método seja determinado em tempo de execução com base no tipo do objeto.
//Polimorfismo: tipos de implementação:
//Com herança: classes derivadas sobrescrevem os membros da classe base
//Com interface: classes que implementam a interface com comportamentos diferentes
//               métodos com o mesmo nome nas classes mas com funcionalidades diferentes
//Com classe abstrata: classes derivadas incluem os detalhes da implementação nos métodos abstratos

var figuras = new List<Figura>
{
    new Triangulo(),
    new Circulo()
};

foreach (var figura in figuras)
{
    figura.Desenhar();

}