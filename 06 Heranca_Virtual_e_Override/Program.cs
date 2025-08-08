Console.WriteLine("*** Herança: Virtual e Override ***");
//Para substituir um membro da classe base por um membro da subclasse com o mesmo nome
//Usa-se o modificador virtual na declaração do membro da classe base
//Tambem usa-se o modificador override na declaração de membros da classe derivada
Console.WriteLine("\nUsa o método sobrescrito da classe Gato");
Cachorro cachorro = new() { Nome = "Pulguento"};
cachorro.ExibeNome();
Console.WriteLine("\nUsa o método da classe base Animal");
Galo galinho = new() { Nome = "Briguento" };
galinho.ExibeNome();


Console.ReadLine();

public class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome()
    {
        Console.WriteLine($"\nMeu nome é {Nome}");
    }
}

public class Cachorro : Animal
{
    public override void ExibeNome()
    {
        Console.WriteLine($"\nEsse animal é um cachorro. O nome dele é: {Nome}");
    }
}


public class Galo : Animal
{

}