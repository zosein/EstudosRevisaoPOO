Console.WriteLine("*** Herança e Object ***");
//classe Object ==> toda classe deriva da classe Object
//A classe Object não deriva de nenhuma classe
//A classe Object é a classe base de todas as classe, sendo ela quem dá suporte na hierarquia de classes do .NET
//fornecendo o aporte de baixo nível para as classes derivadas
// métodos da classe Object: Equals, GetHashCode, GetType, ToString, etc
//Importante: uma classe só pode herdar de outra classe e apenas de uma classe

Classe1 classe = new();

classe.GetType();
classe.Equals(classe);
classe.ToString();
classe.GetHashCode();


Console.ReadKey();

public class Classe1
{

}

public class Classe2
{

}

public class ClasseDerivada : Classe2
{

}