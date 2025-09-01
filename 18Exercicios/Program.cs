using _18Exercicios.Exercicio1;
using _18Exercicios.Exercicio2;
using _18Exercicios.Exercicio3;

//Exercicio1
Carro carro = new Carro(0);
Console.WriteLine("Informe quantos litros de gasolina: ");
int gasolina = Convert.ToInt32(Console.ReadLine());
if (carro.Abastecer(gasolina))
{
    carro.Dirigir();
}

//Exercicio2
LivroFotos meuAlbum1 = new LivroFotos();
Console.Write("Criando um Livro de fotos com ");
Console.Write(meuAlbum1.GetNumeroPaginas());
Console.Write(" páginas\n");
LivroFotos meuAlbum2 = new LivroFotos(24);
Console.Write("Criando um Livro de fotos com ");
Console.Write(meuAlbum2.GetNumeroPaginas());
Console.Write(" páginas\n");
SuperLivroFotos meuSuperAlbum1 = new SuperLivroFotos();
Console.Write("Criando um Livro de fotos com ");
Console.Write(meuSuperAlbum1.GetNumeroPaginas());
Console.Write(" páginas\n");
Console.ReadLine();


//Exercicio3
List<Pessoa> pessoas = new List<Pessoa>();

Console.Write("Digite o nome do primeiro aluno: ");
string? nomeAluno1 = Console.ReadLine();
pessoas.Add(new Aluno(nomeAluno1 ?? string.Empty));

Console.Write("Digite o nome do segundo aluno: ");
string? nomeAluno2 = Console.ReadLine();
pessoas.Add(new Aluno(nomeAluno2 ?? string.Empty));

Console.Write("Digite o nome do terceiro aluno: ");
string? nomeAluno3 = Console.ReadLine();
pessoas.Add(new Aluno(nomeAluno3 ?? string.Empty));

Console.WriteLine("\n--- Execuntando ações ---");

foreach (Pessoa p in pessoas)
{
    Console.WriteLine(p.ToString());

    if (p is Aluno aluno)
    {
        aluno.Estudar();
    }
    else if (p is Professor professor)
    {
        professor.Explicar();
    }
}
