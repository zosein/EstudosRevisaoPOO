using _18Exercicios;

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