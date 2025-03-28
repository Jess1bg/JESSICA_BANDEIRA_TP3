using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Testando Geometria ===");

        Circulo c = new Circulo();
        c.Raio = 5.0;
        Console.WriteLine($"Círculo criado. Raio = {c.Raio}");

        Esfera e = new Esfera();
        e.Raio = 3.0;
        Console.WriteLine($"Esfera criada. Raio = {e.Raio}");

        Console.WriteLine("\nPressione ENTER para sair...");
        Console.ReadLine();
    }
}