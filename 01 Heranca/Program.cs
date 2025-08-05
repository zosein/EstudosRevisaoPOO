Console.WriteLine("*** POO - Herança ***");

Funcionario func = new();
func.Nome = "José";
func.Email = "jose@email.com";
func.Empresa = "Amazon";
func.Salario = 9000;

Console.WriteLine("Funcionário: ");
Console.WriteLine(func.Empresa);
Console.WriteLine(func.Salario);
func.Identificar();

Aluno alumni = new Aluno();
alumni.Nome = "Roberto";
alumni.Email = "roberto@alumni.com";
alumni.Curso = "Arquitetura";
alumni.Nota = 9;

Console.WriteLine("Aluno: ");
Console.WriteLine(alumni.Curso);
Console.WriteLine(alumni.Nota);
alumni.Identificar();


Console.ReadKey();

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}