using _11_upcasting_downcasting;
//upcasting implicito (Cachorro -> Animal)
Cachorro meuCachorro = new Cachorro();
Animal animal = meuCachorro; //conversão automatica

animal.Comer(); //metodo da classe base (valido)

Console.WriteLine(animal.GetType());//para mostrar "Cachorro" o objeto não muda

//upcasting inicial
Forma forma = new Circulo();//refencia um circulo

//downcasting explicito (forma -> circulo)
//metodo 1: operador de cast (ira lançar exceção se falhar)
Circulo circulo1 = (Circulo)forma;
circulo1.Zoom();

//metodo 2: operador "as" (retorna null caso falhe)
Circulo circulo2 = forma as Circulo;
if (circulo2 != null)
    circulo2.Zoom();

//metodo 3: verificacao com "is"
if (forma is  Circulo circuloSeguro)
    circuloSeguro.Zoom();//cast implicito seguro

//cenario de falha
/* Forma circuloInvalido = new Forma();
    Circulo invalido = (Circulo)formaInvalida;//InvalidCastException
*/