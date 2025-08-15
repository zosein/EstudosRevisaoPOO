//O uso do modificador abstract indica que o recurso a ser modificado tem implementação incompleta ou inexistente
//Pode ser usado em classes, metodos, propriedades, indexadores e eventos
//O uso em classes sinaliza que um classe é somente usada como base (um esqueleto) para outras classes, não podendo ser instanciada
//Membros marcados com abstract são implementados por classes não abstratas que derivam de uma outra classe abstrata

using _12_Classe_Abstrata;

Quadrado quadrado = new Quadrado();
Console.WriteLine(quadrado.Descricao());

Console.WriteLine("\nIforma qual a cor da figura: ");
quadrado.Cor = Console.ReadLine();

Console.WriteLine("\nInforme os valores dos lados do quadrado");
quadrado.Lado = Convert.ToInt32(Console.ReadLine());

quadrado.CalcularArea();
quadrado.CalcularPerimetro();


Console.WriteLine($"\nÁrea do quadrado: {quadrado.Area} m2");
 Console.WriteLine($"\nPerímetro do quadrado: {quadrado.Perimetro} m2");

Console.WriteLine($"\nO quadrado tem a cpr : {quadrado.Cor}");
Console.ReadKey();
