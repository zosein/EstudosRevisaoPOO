//Uma interface é um tipo de classe que pode conter assinaturas de metodos, eventos, propriedades e indexadoress
//Tambem pode conter metodos publicos e estaticos que contem uma implementacao


IControle control = new Exemplo();
control.Nome = "Teste";
control.Pintar();
control.Exibir();


Console.ReadKey();


interface IControle
{
    string? Nome { get; set; }
    void Pintar();
    public void Exibir()
    {
        Console.WriteLine("Teste");
    }
    
}

interface IGrafico
{
    void Desenhar();
}

public class Exemplo: IControle, IGrafico
{
    public string? Nome { get; set; } = string.Empty;
    public void Pintar()
    {
        Console.WriteLine("Pintando...");
    }

    public void Desenhar()
    {
        Console.WriteLine("Desenhando...");
    }
}