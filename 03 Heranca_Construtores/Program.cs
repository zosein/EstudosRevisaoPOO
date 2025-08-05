Console.WriteLine("*** Herança - Construtores ***");
// a classe base e a classe derivada podem possuir seus próprios construtores
// a classe derivada não herda o construtor da classe base mas pode invoca-lo
//Ao criar uma instância da classe derivada o construtor da classe base sem parâmetros
//será invocado primeiro e depois será invocado o construtor da classe derivada

Aluno aluno1 = new Aluno();
Aluno aluno2 = new Aluno("José");


Console.ReadKey();

//classe base
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da classe Pessoa com parametro");
    }
}

//classe derivada
class Aluno : Pessoa
{
    public Aluno() : base()
    {
        Console.WriteLine("Construtor da classe Aluno");
    }
    public Aluno(string nome) : base(nome)
    {
        Console.WriteLine("Construtor da classe Aluno com parametro");
    }
}