using System;
class Carro
{
    public string Cor;
    public int Potencia;

    public void Apresentar()
    {
        Console.WriteLine($"Este carro tem cor {Cor} e {Potencia}CV de potência.");
    }
}

class Program
{
    static void Main()
    {
        Carro hilux = new Carro();

        hilux.Cor = "Prata";
        hilux.Potencia = 204;

        hilux.Apresentar();

    }
}