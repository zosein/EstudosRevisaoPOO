//Tipos de relacionamentos entre classes
//1)Relação de especialização e herança - "é um" ou "is a"
//2)Relação de Composição - representa uma relação do tipo "tem um" e "parte-de"
//-> ocorre quando um objeto de uma classe é composto de um ou mais objetos de outras classes
//-> é formado qnd uma classe tem uma referencia a outra classe como propriedade de instância
//-> classe pai é proprietaria da classe filha, classe filha ñ existe sem a classe pai
//3)Relação de Agregação - representa uma relação do tipo "tem-um"
//é um tipo especial de composição onde objetos de uma classe podem conter 1+ objetos de outra classe
//na agregação a parte e o todos são independentes, a parte pode existir sem o todo

using _15_Composicao;

Professor prof1 = new Professor("Carlos", "Física");
Professor prof2 = new Professor("Getulio", "Português");
Professor prof3 = new Professor("Luiz", "Matematica");
Professor prof4 = new Professor("Ana", "Artes");

Departamento dep1 = new Departamento("Exatas");
Departamento dep2 = new Departamento("Humanas");

dep1.IncluirProfessor(prof1);
dep1.IncluirProfessor(prof3);
dep1.ListaProfessores();

dep2.IncluirProfessor(prof2);
dep2.IncluirProfessor(prof4);
dep2.ListaProfessores();

Console.ReadKey();