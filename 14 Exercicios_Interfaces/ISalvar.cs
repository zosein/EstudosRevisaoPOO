namespace _14_Exercicios_Interfaces;

public interface ISalvar
{
    void Salvar();

    void Compactar()
    {
        Console.WriteLine("Compactando arquivos");
    }
}
