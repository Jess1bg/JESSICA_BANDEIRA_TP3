using System;

class TestaFiguras
{
    static void Main()
    {
        Circulo circulo = new Circulo();
        circulo.Raio = 3.0;
        double area = circulo.CalcularArea();
        Console.WriteLine("=== TESTE DO CÍRCULO ===");
        Console.WriteLine($"Raio: {circulo.Raio}");
        Console.WriteLine($"Área: {area:F2}\n");

        Esfera esfera = new Esfera();
        esfera.Raio = 5.0;
        double volume = esfera.CalcularVolume();
        Console.WriteLine("=== TESTE DA ESFERA ===");
        Console.WriteLine($"Raio: {esfera.Raio}");
        Console.WriteLine($"Volume: {volume:F2}");

        Console.WriteLine("\nPressione ENTER para sair...");
        Console.ReadLine();
    }
}