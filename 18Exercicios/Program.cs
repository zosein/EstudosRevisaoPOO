using _18Exercicios;

Carro carro = new Carro(0);
Console.WriteLine("Informe quantos litros de gasolina: ");
int gasolina = Convert.ToInt32(Console.ReadLine());
if (carro.Abastecer(gasolina))
{
    carro.Dirigir();
}