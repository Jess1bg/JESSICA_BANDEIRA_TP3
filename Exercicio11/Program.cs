using System;

class Program
{
    static void Main()
    {
        // Círculo
        Circulo circulo = new Circulo();
        circulo.Raio = 7.0;
        double areaCirculo = circulo.CalcularArea();
        Console.WriteLine($"Área do círculo (raio = {circulo.Raio}): {areaCirculo:F2}");

        // Esfera
        Esfera esfera = new Esfera();
        esfera.Raio = 6.0;
        double volumeEsfera = esfera.CalcularVolume();
        Console.WriteLine($"Volume da esfera (raio = {esfera.Raio}): {volumeEsfera:F2}");

        Console.WriteLine("\nPressione ENTER para sair...");
        Console.ReadLine();
    }
}