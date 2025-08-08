Console.WriteLine("*** Herança e modificador new ***");
//Quando um membro da classe derivada tem o mesmo nome de uma classe base, o compilador emite um aviso
//O aviso serve para indicar que o membro da classe derivada oculta o membro da classe base
//Esse ocorrido é chamado de override

Aluno aluno = new();
aluno.Nome = "Teca";
aluno.Curso = "Engenharia";

Console.WriteLine(aluno.Saudacao());


Console.ReadLine();

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Saudacao() => $"Oi, eu sou o(a) {Nome}";
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public new string Saudacao()
        => $"Oi, eu sou o(a) {Nome} do curso de : {Curso}";
}