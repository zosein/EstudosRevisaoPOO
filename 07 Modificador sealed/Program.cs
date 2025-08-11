Console.WriteLine("### Modificador sealed ###\n");
//Quando aplicado a uma classe, o modificador sealed impede que outras classes herdem dela
//O modificador sealed pode ser usado em métodos ou propriedades que substituem
//métodos ou propriedades virtual de classes bases
//Isso permite que classes sejam derivadas de sua classe, mas evita que outros desenvolvedores
//que usam suas classes alterem métodos e propriedades virtuais especificos




Console.ReadKey();

class ClasseBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }
    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

class ClasseDeriv1 : ClasseBase
{
    sealed protected override void Metodo1()
    {
        Console.WriteLine("ClasseDeriv1.Metodo1()");
    }
    protected override void Metodo2()
    {
        Console.WriteLine("Classe1.Metodo2()");
    }
}

class ClasseDeriv2 : ClasseDeriv1
{
    protected override void Metodo1()//CS0239: cannot override inherited member because its sealed
    {
        Console.WriteLine("ClasseDeriv1.Metodo1()");
    }
    protected override void Metodo2()
    {
        Console.WriteLine("Classe1.Metodo2()");
    }
}